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

        private LeistungsverzeichnisPositionHinweistextApiModel[] _LeistungsverzeichnisPositionHinweistexte = new [] {
                new LeistungsverzeichnisPositionHinweistextApiModel {
                    LeistungsverzeichnisId = 3,
                    HinweistextId = 1
                },
                new LeistungsverzeichnisPositionHinweistextApiModel {
                    LeistungsverzeichnisId = 3,
                    HinweistextId = 2
                }
            };

        public Task<LeistungsverzeichnisPositionApiModel[]> GetLeistungsverzeichnisPositionenAsync()
        {
            var result = new [] {
                new LeistungsverzeichnisPositionApiModel {
                    Id = 1,
                    Ordnungszahl = "01",
                    Kurztext = "Neubau"
                },
                new LeistungsverzeichnisPositionApiModel {
                    Id = 2,
                    Ordnungszahl = "01.01",
                    Kurztext = "Baustelleneinrichtung"
                },
                new LeistungsverzeichnisPositionApiModel {
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
