using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace maui_data_grid_import_from_excel;

public class Customer {
    public string Company { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
