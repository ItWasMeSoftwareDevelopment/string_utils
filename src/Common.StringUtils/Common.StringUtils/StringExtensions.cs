using System.Globalization;
using System.Linq;
using System.Text;

namespace ItWasMe.Common.StringUtils
{
    public static class StringExtensions
    {
        public static string NormalizeToForm(this string input, NormalizationForm normalizationForm = NormalizationForm.FormD)
        {
            return string.Concat(input.Normalize(NormalizationForm.FormD).Where(
                c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark));
        }
    }
}
