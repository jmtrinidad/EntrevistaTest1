using EntrevistaTest1.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EntrevistaTest1.WindowForms
{
    public partial class Form1 : Form
    {
        private readonly DataAccess.Data.DataAccess dataAccess;

        public Form1()
        {
            InitializeComponent();
            dataAccess = new DataAccess.Data.DataAccess();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgListado1.DataSource = dataAccess.GetAddressesAC();
            dtgListado2.DataSource = dataAccess.GetAddressesEntrevista1Test();
        }

        private void btnInsertAddress_Click(object sender, EventArgs e)
        {
            var resultList = dataAccess.GetAddressesAC();
            if (resultList != null)
            {
                var result = dataAccess.CreateAddress(resultList);
                if (result)
                {
                    dtgListado2.DataSource = dataAccess.GetAddressesEntrevista1Test();
                }
            }
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            var results = dataAccess.GetAddressesEntrevista1Test();
            var tokens = new List<Token>();

            if (results.Count > 0)
            {
                foreach (var item in results)
                {
                    if (!string.IsNullOrEmpty(item.Direction))
                    {
                        if (item.Direction.Contains("#") ||
                            item.Direction.Contains(".") ||
                            item.Direction.Contains(",") ||
                            item.Direction.Contains(";"))
                        {
                            var filter = item.Direction.Replace("#", "?");
                            filter = filter.Replace(".", "?");
                            filter = filter.Replace(",", "?");
                            filter = filter.Replace(";", "?");
                            var result = filter.Split('?');

                            for (int j = 0; j < result.Length; j++)
                            {
                                var token = new Token
                                {
                                    DirectionId = item.Id,
                                    Tokens = result[j],
                                };
                                tokens.Add(token);
                            }
                        }
                        else
                        {
                            var token = new Token
                            {
                                DirectionId = item.Id,
                                Tokens = item.Direction,
                            };

                            tokens.Add(token);
                        }
                    }
                }
                var result2 = dataAccess.CreateTokens(tokens);
                if (result2)
                {
                    dtgListado3.DataSource = tokens;
                }
            }
        }
    }
}
