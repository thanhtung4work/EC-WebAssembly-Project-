using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin.Data;

namespace Admin
{
    public partial class ExportSuchimnuController : ExportController
    {
        private readonly SuchimnuContext context;
        public ExportSuchimnuController(SuchimnuContext context)
        {
            this.context = context;
        }

        [HttpGet("/export/Suchimnu/categories/csv")]
        [HttpGet("/export/Suchimnu/categories/csv(fileName='{fileName}')")]
        public FileStreamResult ExportCategoriesToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.Categories, Request.Query), fileName);
        }

        [HttpGet("/export/Suchimnu/categories/excel")]
        [HttpGet("/export/Suchimnu/categories/excel(fileName='{fileName}')")]
        public FileStreamResult ExportCategoriesToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.Categories, Request.Query), fileName);
        }
        [HttpGet("/export/Suchimnu/games/csv")]
        [HttpGet("/export/Suchimnu/games/csv(fileName='{fileName}')")]
        public FileStreamResult ExportGamesToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.Games, Request.Query), fileName);
        }

        [HttpGet("/export/Suchimnu/games/excel")]
        [HttpGet("/export/Suchimnu/games/excel(fileName='{fileName}')")]
        public FileStreamResult ExportGamesToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.Games, Request.Query), fileName);
        }
        [HttpGet("/export/Suchimnu/stats/csv")]
        [HttpGet("/export/Suchimnu/stats/csv(fileName='{fileName}')")]
        public FileStreamResult ExportStatsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.Stats, Request.Query), fileName);
        }

        [HttpGet("/export/Suchimnu/stats/excel")]
        [HttpGet("/export/Suchimnu/stats/excel(fileName='{fileName}')")]
        public FileStreamResult ExportStatsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.Stats, Request.Query), fileName);
        }
        [HttpGet("/export/Suchimnu/studios/csv")]
        [HttpGet("/export/Suchimnu/studios/csv(fileName='{fileName}')")]
        public FileStreamResult ExportStudiosToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.Studios, Request.Query), fileName);
        }

        [HttpGet("/export/Suchimnu/studios/excel")]
        [HttpGet("/export/Suchimnu/studios/excel(fileName='{fileName}')")]
        public FileStreamResult ExportStudiosToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.Studios, Request.Query), fileName);
        }
    }
}
