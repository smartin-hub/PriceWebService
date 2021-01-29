using System.Threading.Tasks;
using PriceWebService.Models;

namespace PriceWebService.Services{
    public interface IPrezziRepository {

        bool PrezzoExists (string CodArt, string IdListino);

        Task<DettListini> SelPrezzoByCodArtAndList(string CodArt, string IdListino);

        Task<bool> DelPrezzoListino(string CodArt, string IdListino);
    }
}