using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTO.Responses;
//kullanıcıya bu id ve bu name ait ayrıca bu tarihte marka oluşturuldu diye mesaj döndürecek.
public class CreatedBrandResponse
{
    public int ID { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
}

