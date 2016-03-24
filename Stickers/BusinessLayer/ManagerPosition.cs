using System.Collections.Generic;
using Contracts.IManager;
using DTO.Entities;

namespace BusinessLayer
{
    public  class ManagerPosition:BaseManager, IManagerPosition
    {
        public IEnumerable<PositionDto> GetAllPositions()
        {
           return _srv.Positions.GetList();
        }

        public void AddPosition(PositionDto position)
        {
            _srv.Positions.Add(position);
        }

        public void RemovePosition(PositionDto position)
        {
            _srv.Positions.Remove(position);
        }

    }
}
