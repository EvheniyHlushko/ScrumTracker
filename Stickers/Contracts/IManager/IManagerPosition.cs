using System.Collections.Generic;
using DTO.Entities;

namespace Contracts.IManager
{
    public interface IManagerPosition
    {
        IEnumerable<PositionDto> GetAllPositions();

        void AddPosition(PositionDto position);

        void RemovePosition(PositionDto position);
    }
}