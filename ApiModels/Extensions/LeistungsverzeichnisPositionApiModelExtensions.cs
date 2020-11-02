using BrzMobileLvTrailWork.ApiModels;

namespace BrzMobileLvTrailWork.ApiModels.Extensions.LeistungsverzeichnisPositionApiModelExtensions
{
    public static class Implementation
    {
        public static bool HasLangtext(this LeistungsverzeichnisPositionApiModel leistungsverzeichnisPosition)
        {
            return !string.IsNullOrWhiteSpace(leistungsverzeichnisPosition.Langtext);
        }
    }
}
