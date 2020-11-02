using System;
using System.Linq;
using System.Threading.Tasks;
using BrzMobileLvTrailWork.ApiModels;

namespace BrzMobileLvTrailWork.Services
{
    public class LeistungsverzeichnisService
    {
        private HinweistextApiModel[] _Hinweistexte = new [] {
                new HinweistextApiModel {
                    Id = 1,
                    Kurzbezeichnung = "Hinweis zu Auf- und Abbau",
                    PlainText = "Der Zaun ist aufzustellen und nach Abschluss aller Bauarbeiten wieder abzubauen."
                },
                new HinweistextApiModel {
                    Id = 2,
                    Kurzbezeichnung = "Besonderheiten",
                    PlainText = "Türen und Tore werden gesondert vergütet."
                }
            };

        private LeistungsverzeichnisHinweistextApiModel[] _LeistungsverzeichnisHinweistexte = new [] {
                new LeistungsverzeichnisHinweistextApiModel {
                    LeistungsverzeichnisId = 3,
                    HinweistextId = 1
                },
                new LeistungsverzeichnisHinweistextApiModel {
                    LeistungsverzeichnisId = 3,
                    HinweistextId = 2
                }
            };

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
                    Gesamtpreis = 399.45m,
                    Langtext = "Bauzaun aus mobilen Stahlrahmenelementen mit Rundstahlfüllstäben, Stützfüßen aus Beton, inkl. sämtlicher Verbindungen, Kupplungen etc.",
                    IsNachtragsPosition = true
                }
            };

            return Task.FromResult(result.ToArray());
        }
    }
}
