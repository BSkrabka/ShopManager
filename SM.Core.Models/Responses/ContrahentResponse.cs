using SM.Data.Models;
using SM.Data.Models.Shop;

namespace SM.Core.Models.Responses;

public class ContrahentResponse : BaseResponse
{
    public ContrahentResponse(Contrahent contrahent) : base(contrahent)
    {
        Name = contrahent.Name;
        Margin = contrahent.Margin;
    }

    public string Name { get; set; }
    public double Margin { get; set; }
}