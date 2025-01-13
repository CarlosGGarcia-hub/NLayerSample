
using BLL.Logic;
using DAL;
using DAL.DTO;

namespace Services
{
    public class EquipoService
    {
        public readonly EquipoRepository _equipoRepository;

        public EquipoService(AppDbContext dbContext)
        {
            _equipoRepository = new EquipoRepository(dbContext);
        }

        public List<PosicionJugador> ObtenerEquipo(string documento) 
        {
            return _equipoRepository.ObtenerPosicion(documento);
        }
    }
}
