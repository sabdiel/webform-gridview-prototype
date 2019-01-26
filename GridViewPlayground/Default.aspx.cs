using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridViewPlayground
{
    public class PromotionLanguage
    {
        public int PromotionId { get; set; }
        public int LanguageId { get; set; }
        public string PromotionName { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
    }

    public partial class _Default : Page
    {
        private List<PromotionLanguage> languages { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

                languages = new List<PromotionLanguage>
            {
                new PromotionLanguage
                {
                    PromotionId = 1,
                    LanguageId = 1,
                    PromotionName = "Promotion Name 1",
                    Description = "Description 1",
                    Notes = "Note 1"
                },
                new PromotionLanguage
                {
                    PromotionId = 2,
                    LanguageId = 2,
                    PromotionName = "Promotion Name 2",
                    Description = "Description 2",
                    Notes = "Note 2"
                },
                new PromotionLanguage
                {
                    PromotionId = 3,
                    LanguageId = 3,
                    PromotionName = "Promotion Name 3",
                    Description = "Description 3",
                    Notes = "Note 3"
                }
            };

                LoadGrid();

        }

        private void LoadGrid()
        {
            GridView1.DataSource = languages;
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            LoadGrid();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            LoadGrid();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            LoadGrid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int promotionId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];

            TextBox promotionName = (TextBox)row.Cells[2].Controls[0];
            TextBox description = (TextBox)row.Cells[3].Controls[0];
            TextBox notes = (TextBox)row.Cells[4].Controls[0];

            languages[e.RowIndex].PromotionName = promotionName.Text;
            languages[e.RowIndex].Description = description.Text;
            languages[e.RowIndex].Notes = notes.Text;
            
            GridView1.EditIndex = -1;

            LoadGrid();
        }
    }
}