using System;
using System.Net;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNet.OData.Query;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;




namespace Admin.Controllers.Suchimnu
{
  using Models;
  using Data;
  using Models.Suchimnu;

  [ODataRoutePrefix("odata/suchimnu/Categories")]
  [Route("mvc/odata/suchimnu/Categories")]
  public partial class CategoriesController : ODataController
  {
    private Data.SuchimnuContext context;

    public CategoriesController(Data.SuchimnuContext context)
    {
      this.context = context;
    }
    // GET /odata/Suchimnu/Categories
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Suchimnu.Category> GetCategories()
    {
      var items = this.context.Categories.AsQueryable<Models.Suchimnu.Category>();
      this.OnCategoriesRead(ref items);

      return items;
    }

    partial void OnCategoriesRead(ref IQueryable<Models.Suchimnu.Category> items);

    partial void OnCategoryGet(ref SingleResult<Models.Suchimnu.Category> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{Id}")]
    public SingleResult<Category> GetCategory(int key)
    {
        var items = this.context.Categories.Where(i=>i.Id == key);
        var result = SingleResult.Create(items);

        OnCategoryGet(ref result);

        return result;
    }
    partial void OnCategoryDeleted(Models.Suchimnu.Category item);
    partial void OnAfterCategoryDeleted(Models.Suchimnu.Category item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteCategory(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var items = this.context.Categories
                .Where(i => i.Id == key)
                .Include(i => i.Games)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.Suchimnu.Category>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnCategoryDeleted(item);
            this.context.Categories.Remove(item);
            this.context.SaveChanges();
            this.OnAfterCategoryDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnCategoryUpdated(Models.Suchimnu.Category item);
    partial void OnAfterCategoryUpdated(Models.Suchimnu.Category item);

    [HttpPut("{Id}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutCategory(int key, [FromBody]Models.Suchimnu.Category newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.Categories
                .Where(i => i.Id == key)
                .Include(i => i.Games)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.Suchimnu.Category>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnCategoryUpdated(newItem);
            this.context.Categories.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Categories.Where(i => i.Id == key);
            this.OnAfterCategoryUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{Id}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchCategory(int key, [FromBody]Delta<Models.Suchimnu.Category> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.Categories.Where(i => i.Id == key);

            items = EntityPatch.ApplyTo<Models.Suchimnu.Category>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            patch.Patch(item);

            this.OnCategoryUpdated(item);
            this.context.Categories.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Categories.Where(i => i.Id == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnCategoryCreated(Models.Suchimnu.Category item);
    partial void OnAfterCategoryCreated(Models.Suchimnu.Category item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Suchimnu.Category item)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (item == null)
            {
                return BadRequest();
            }

            this.OnCategoryCreated(item);
            this.context.Categories.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Suchimnu/Categories/{item.Id}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
