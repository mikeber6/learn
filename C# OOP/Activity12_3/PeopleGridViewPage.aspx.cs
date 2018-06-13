using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PeopleGridViewPage : System.Web.UI.Page
{
    WideWorldImportersEntities dbContext = new WideWorldImportersEntities();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
    }

    public IQueryable<Person> GetPeople()
    {
        var _People = dbContext.People;
        return _People;
    }

    public void UpdatePeople(Person person)
    {
        var _People = dbContext.People.Find(person.PersonID);
        TryUpdateModel(_People);

        if (ModelState.IsValid)
        {
            dbContext.SaveChanges();
        }
    }

}