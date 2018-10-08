using System;
using System.Collections.Generic;
using System.Text;
using BaseApiCore.Model;
using BaseApiCore.Repository;
using BaseApiCore.Data.DbRepositories.Interfaces;

namespace BaseApiCore.Business
{
    public class DomainLogic : IDomain
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStateRepository _stateRepository;
        public DomainLogic(IUnitOfWork unitOfWork, IStateRepository stateRepository)
        {
            _unitOfWork = unitOfWork;
            _stateRepository = stateRepository;
        }
        public StateReponse GetStates()
        {
            var res = _stateRepository.Get();
            return new StateReponse { States = res };
        }
    }
}
