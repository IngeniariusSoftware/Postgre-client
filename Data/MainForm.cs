using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data
{
    using System.Text.RegularExpressions;

    using Npgsql;

    using ScintillaNET;

    public partial class MainForm : Form
    {
        private void InitializeScintilla()
        {
            Scintilla.StyleResetDefault();
            Scintilla.Styles[Style.Default].Font = "Courier New";
            Scintilla.Styles[Style.Default].Size = 20;
            Scintilla.StyleClearAll();

            // Set the SQL Lexer
            Scintilla.Lexer = Lexer.Sql;

            // Show line numbers
            Scintilla.Margins[0].Width = 20;

            // Set the Styles
            Scintilla.Styles[Style.LineNumber].ForeColor = Color.FromArgb(255, 128, 128, 128); //Dark Gray
            Scintilla.Styles[Style.LineNumber].BackColor = Color.FromArgb(255, 228, 228, 228); //Light Gray
            Scintilla.Styles[Style.Sql.Comment].ForeColor = Color.Green;
            Scintilla.Styles[Style.Sql.CommentLine].ForeColor = Color.Green;
            Scintilla.Styles[Style.Sql.CommentLineDoc].ForeColor = Color.Green;
            Scintilla.Styles[Style.Sql.Number].ForeColor = Color.Maroon;
            Scintilla.Styles[Style.Sql.Word].ForeColor = Color.Blue;
            Scintilla.Styles[Style.Sql.Word2].ForeColor = Color.Fuchsia;
            Scintilla.Styles[Style.Sql.User1].ForeColor = Color.Gray;
            Scintilla.Styles[Style.Sql.User2].ForeColor = Color.FromArgb(255, 00, 128, 192); //Medium Blue-Green
            Scintilla.Styles[Style.Sql.String].ForeColor = Color.Red;
            Scintilla.Styles[Style.Sql.Character].ForeColor = Color.Red;
            Scintilla.Styles[Style.Sql.Operator].ForeColor = Color.Black;

            // Set keyword lists
            // Word = 0
            Scintilla.SetKeywords(0,
                @"add alter as authorization backup begin bigint binary bit break browse bulk by cascade case catch check checkpoint close clustered column commit compute constraint containstable continue create current cursor cursor database date datetime datetime2 datetimeoffset dbcc deallocate decimal declare default delete deny desc disk distinct distributed double drop dump else end errlvl escape except exec execute exit external fetch file fillfactor float for foreign freetext freetexttable from full function goto grant group having hierarchyid holdlock identity identity_insert identitycol if image index insert int intersect into key kill lineno load merge money national nchar nocheck nocount nolock nonclustered ntext numeric nvarchar of off offsets on open opendatasource openquery openrowset openxml option order over percent plan precision primary print proc procedure public raiserror read readtext real reconfigure references replication restore restrict return revert revoke rollback rowcount rowguidcol rule save schema securityaudit select set setuser shutdown smalldatetime smallint smallmoney sql_variant statistics table table tablesample text textsize then time timestamp tinyint to top tran transaction trigger truncate try union unique uniqueidentifier update updatetext use user values varbinary varchar varying view waitfor when where while with writetext xml go ");
            // Word2 = 1
            Scintilla.SetKeywords(1,
                @"ascii cast char charindex ceiling coalesce collate contains convert current_date current_time current_timestamp current_user floor isnull max min nullif object_id session_user substring system_user tsequal ");
            // User1 = 4
            Scintilla.SetKeywords(4,
                @"all and any between cross exists in inner is join left like not null or outer pivot right some unpivot ( ) * ");
            // Подсветка таблиц 
            string keyWords = "";
            Data.GetObjects("alltables").ForEach(x => keyWords += (x + " "));
            Data.GetObjects("schemes").ForEach(x => keyWords += (x + " "));
            Scintilla.SetKeywords(5, keyWords);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(NpgsqlConnection connection)
        {
            InitializeComponent();
            Data = new DataManager(connection);
            InitializeScintilla();
        }

        public DataManager Data { get; }

        private void SchemeTreeView_MouseClick(object sender, MouseEventArgs e)
        {
            //List<string> list = GetTablesList();
            int i;
            i = 10;
        }

        private List<string> GetKitNodes(List<string> nodes, TreeViewEventArgs e)
        {
            TreeNodeCollection nodesForDelete = e.Node.Nodes;
            List<string> nodesForAdd = new List<string>();
            for (int i = 0; i < nodes.Count; i++)
            {
                bool find = false;
                for (int j = 0; j < e.Node.Nodes.Count; j++)
                {
                    if (e.Node.Nodes[j].Text == nodes[i])
                    {
                        find = true;
                        nodesForDelete.Remove(e.Node.Nodes[j]);
                    }
                }

                if (!find)
                {
                    nodesForAdd.Add(nodes[i]);
                }
            }

            for (int i = 0; i < nodesForDelete.Count; i++)
            {
                e.Node.Nodes.Remove(nodesForDelete[i]);
            }

            return nodesForAdd;
        }

        private void SchemeTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Console.WriteLine(e.Node.FullPath);
            Console.WriteLine(e.Node.Name);
            List<string> nodes = new List<string>();
            string[] tokens = e.Node.FullPath.Split('/');
            if (tokens.Length > 3)
            {
                Data.CurrentScheme = tokens[2];
            }

            switch (e.Node.FullPath.Count(x => x == '/'))
            {
                case 0:
                    {
                        if (e.Node.Nodes.Count == 0)
                        {
                            e.Node.Nodes.Add("Схемы");
                        }

                        break;
                    }

                case 1:
                    {
                        nodes = Data.GetObjects("schemes");

                        foreach (string kitNode in GetKitNodes(nodes, e))
                        {
                            e.Node.Nodes.Add(kitNode);
                            e.Node.Nodes[e.Node.Nodes.Count - 1].Name = "schemes";
                        }

                        break;
                    }

                case 2:
                    {
                        if (e.Node.Nodes.Count == 0)
                        {
                            List<string> nodesText = new List<string> { "Таблицы", "Процедуры", "Представления" };
                            nodes = new List<string> { "tables", "procedures", "views" };
                            for (int i = 0; i < nodesText.Count; i++)
                            {
                                e.Node.Nodes.Add(nodesText[i]);
                                e.Node.Nodes[i].Name = nodes[i];
                            }
                        }

                        break;
                    }

                case 3:
                    {
                        nodes = Data.GetObjects(e.Node.Name);

                        foreach (string kitNode in GetKitNodes(nodes, e))
                        {
                            e.Node.Nodes.Add(kitNode);
                            e.Node.Nodes[e.Node.Nodes.Count - 1].Name = e.Node.Name.Substring(0, e.Node.Name.Length - 1);
                        }

                        break;
                    }

                case 4:
                    {
                        DataView.DataSource = Data.GetTable(e.Node.Name, e.Node.Text);
                        break;
                    }
            }
        }

        private void form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
                ResultView.DataSource = Data.GetDataSet(Scintilla.Text).Tables[0];
            }
        }
    }
}
