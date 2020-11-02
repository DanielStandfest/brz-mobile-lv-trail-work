using BrzMobileLvTrailWork.ApiModels;

namespace BrzMobileLvTrailWork.ApiModels.Extensions.LeistungsverzeichnisApiModelExtensions
{
    public static class Implementation
    {
        public static bool HasLangtext(this LeistungsverzeichnisApiModel leistungsverzeichnis)
        {
            return !string.IsNullOrWhiteSpace(leistungsverzeichnis.Langtext);
        }
    }
}
