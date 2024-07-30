
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TrabalhoAvalonia.Model;

public class ToDoItem {

    public string Title { get; set; }
    public string Description { get; set; }
    public ToDoItem(string title, string description) {
        Title = title;
        Description = description;
    }

}
