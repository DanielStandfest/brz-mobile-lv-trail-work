using System;
using System.Linq;
using System.Threading.Tasks;
using BrzMobileLvTrailWork.ApiModels;

namespace BrzMobileLvTrailWork.Services
{
    public class LeistungsverzeichnisService
    {
        public Task<LeistungsverzeichnisApiModel[]> GetLeistungsverzeichnisseAsync()
        {
            var result = new [] {
                new LeistungsverzeichnisApiModel {
                    Id = 1,
                    Ordnungszahl = "01",
                    Kurztext = "Neubau"
                },
                new LeistungsverzeichnisApiModel {
                    Id = 2,
                    Ordnungszahl = "01.01",
                    Kurztext = "Baustelleneinrichtung"
                },
                new LeistungsverzeichnisApiModel {
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
