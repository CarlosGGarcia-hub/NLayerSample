﻿
using DAL;
using DAL.DTO;

namespace BLL.Logic
{
    public class EquipoRepository
    {
        private readonly AppDbContext _context;

        public EquipoRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;                
        }

        //Entity 
        public List<PosicionJugador> ObtenerPosicion(string documento)
        {

            var result = (from p in _context.Personas
                          join e in _context.Equipos
                          on p.idcolumna equals e.idPersona
                          join po in _context.Posciciones
                          on e.Idposicion equals po.idPosicion
                          select new PosicionJugador
                          {
                              NombreDelJugador = p.Nombres,
                              Posicion_Jugador = po.NombrePosicion

                          }).ToList();

            return result;

        }
    }
}
