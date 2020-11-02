using System;
using System.Linq;
using System.Threading.Tasks;

namespace BrzMobileLvTrailWork.Data
{
    public class LeistungsverzeichnisService
    {
        public Task<Leistungsverzeichnis[]> GetLeistungsverzeichnisseAsync()
        {
            var result = new [] {
                new Leistungsverzeichnis {
                    Id = 1,
                    Ordnungszahl = "01",
                    Kurztext = "Neubau"
                },
                new Leistungsverzeichnis {
                    Id = 2,
                    Ordnungszahl = "01.01",
                    Kurztext = "Baustelleneinrichtung"
                },
                new Leistungsverzeichnis {
                    Id = 3,
                    Ordnungszahl = "01.01.0010",
                    Kurztext = "Bauzaun",
                    Gesamtpreis = 399.45m
                }
            };

            return Task.FromResult(result.ToArray());
        }
    }
}
