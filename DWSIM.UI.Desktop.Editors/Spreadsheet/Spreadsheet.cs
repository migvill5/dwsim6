﻿using System;
using System.Collections.Generic;
using System.Linq;

using DWSIM.Interfaces;

using Eto.Forms;

using cv = DWSIM.SharedClasses.SystemsOfUnits.Converter;
using Eto.Drawing;

using DWSIM.ExtensionMethods;
using DWSIM.UI.Shared;
using s = DWSIM.UI.Shared.Common;
using System.Collections.ObjectModel;

using global::DWSIM.SharedClasses.Spreadsheet;
using System.Globalization;
using System.Xml.Linq;
using DWSIM.CrossPlatform.UI.Controls.ReoGrid;
using Cell = DWSIM.CrossPlatform.UI.Controls.ReoGrid.Cell;
using DWSIM.CrossPlatform.UI.Controls.ReoGrid.EtoRenderer;
using DWSIM.CrossPlatform.UI.Controls.ReoGrid.Formula;
using DWSIM.UI.Desktop.Shared;

namespace DWSIM.UI.Desktop.Editors
{
    public class Spreadsheet
    {

        public Dictionary<String, Interfaces.ISimulationObject> ObjList;

        protected SpreadsheetCellParameters ccparams;

        public List<List<object>> dt1 = new List<List<object>>();
        public List<List<object>> dt2 = new List<List<object>>();

        private Flowsheet flowsheet;

        private ReoGridFullControl scontrol;

        public ReoGridControl Sheet;

        public bool Loaded = true;

        public Spreadsheet(Flowsheet fs)
        {
            flowsheet = fs;
            scontrol = new ReoGridFullControl();
            Sheet = scontrol.GridControl;
            SetCustomFunctions();
            flowsheet.GetSpreadsheetObject = () => { return Sheet; };
            Sheet.CurrentWorksheet.Name = "MAIN";
        }

        public PixelLayout GetSpreadsheet(IFlowsheet obj)
        {

            return scontrol;

        }

        public void WriteAll()
        {

            foreach (var ws in Sheet.Worksheets)
            {
                ws.Recalculate();
            }

        }

        public void EvaluateAll()
        {
            WriteAll();
        }

        public string GetCellString(SpreadsheetCellParameters cell)
        {
            return cell.CellString;
        }

        public List<string[]> GetDataFromRange(string range)
        {

            var list = new List<string[]>();
            var slist = new List<string>();

            var rdata = Sheet.Worksheets[0].GetRangeData(new RangePosition(range));

            for (var i = 0; i < rdata.GetLength(0); i++)
            {
                slist = new List<string>();
                for (var j = 0; j < rdata.GetLength(1); j++)
                {
                    slist.Add(rdata[i, j].ToString());
                }
                list.Add(slist.ToArray());
            }

            return list;
        }

        public void CopyDT1FromString(string text)
        {
            string[] rows = text.Split('|');
            int n = (rows.Length - 1);
            int m = 0;
            string value;
            var ci = System.Globalization.CultureInfo.InvariantCulture;
            NumberStyles format = (NumberStyles)(NumberStyles.Any - NumberStyles.AllowThousands);
            if ((n > 0))
            {
                m = (rows[0].Split(';').Length - 1);
            }
            if (((n > 0) && (m > 0)))
            {
                List<List<object>> elm = new List<List<object>>();
                try
                {
                    for (int i = 0; (i <= n); i++)
                    {
                        elm.Add(new List<object>());
                        if ((n > 0))
                        {
                            m = (rows[i].Split(';').Length - 1);
                        }

                        for (int j = 0; (j <= m); j++)
                        {
                            value = rows[i].Split(';')[j];
                            double d;
                            if (double.TryParse(value, format, ci, out d))
                            {
                                elm[i].Add(double.Parse(value, format, ci));
                            }
                            else
                            {
                                elm[i].Add(value);
                            }

                        }

                    }

                }
                catch (Exception ex)
                {
                }

                dt1 = elm;
            }


        }

        public void CopyDT2FromString(string text)
        {
            string[] rows = text.Split('|');
            int n = 98;
            int m = 25;
            if (n > 0)
            {
                m = rows[0].Split(';').Length - 1;
            }
            if (n > 0 & m > 0)
            {
                List<List<object>> elm = new List<List<object>>();
                for (int i = 0; i <= n; i++)
                {
                    elm.Add(new List<object>());
                    for (int j = 0; j <= m; j++)
                    {
                        SpreadsheetCellParameters scp = new SpreadsheetCellParameters();
                        try
                        {
                            XElement element = new XElement("dummy");
                            string text0 = rows[i].Replace("&gt;", "greater_than").Replace("&lt;", "less_than");
                            string xmltext = text0.Split(';')[j];
                            if (xmltext != " ")
                            {
                                string text1 = xmltext.Replace("greater_than", "&gt;").Replace("less_than", "&lt;");
                                element = XElement.Parse(text1);
                                scp.LoadData(element.Elements().ToList());
                                elm[i].Add(scp);
                            }
                            else
                            {
                                elm[i].Add(scp);
                            }
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
                dt2 = elm;
            }

        }

        public void CopyFromDT()
        {
            int i, j, n1, m1, n2, m2, maxrow, maxcol;

            n1 = dt1.Count - 1;

            if (n1 == -1) return;

            m1 = dt1[0].Count - 1;

            n2 = dt2.Count - 1;
            m2 = dt2[0].Count - 1;

            maxrow = Sheet.Worksheets[0].RowCount - 1;
            maxcol = Sheet.Worksheets[0].ColumnCount - 1;

            var sheet = Sheet.Worksheets[0];

            for (i = 0; i <= n1; i++)
            {
                for (j = 0; j <= m1; j++)
                {
                    if (i <= maxrow & j <= dt1[i].Count - 1)
                    {
                        if (dt1[i][j] != null) sheet.Cells[i, j].Data = dt1[i][j];
                    }
                    if (i <= n2 & j <= dt2[i].Count)
                    {
                        if (dt2[i][j] == null)
                            sheet.Cells[i, j].Tag = new SpreadsheetCellParameters();
                        else if (dt2[i][j] is SpreadsheetCellParameters)
                            sheet.Cells[i, j].Tag = dt2[i][j];
                        else if (dt2[i][j] is string)
                        {
                            SpreadsheetCellParameters cellparam = new SpreadsheetCellParameters();
                            try
                            {
                                cellparam.Expression = dt2[i][j].ToString();
                                if (cellparam.Expression.StartsWith(":"))
                                {
                                    cellparam.CellType = SharedClasses.Spreadsheet.VarType.Read;
                                    string[] str;
                                    str = cellparam.Expression.Split(new char[] { ',' });
                                    cellparam.ObjectID = str[0].Substring(1);
                                    cellparam.PropID = str[1];
                                }
                                else
                                    cellparam.CellType = SharedClasses.Spreadsheet.VarType.Expression;
                            }
                            catch (Exception ex)
                            {
                            }
                            sheet.Cells[i, j].Tag = cellparam;
                        }
                    }
                }
            }

            ParseOldData();

        }


        void ParseOldData()
        {
            var separator = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ListSeparator;
            var esheet = Sheet.NewWorksheet("EXPORTS");
            List<Tuple<string, string, string, string>> elist = new List<Tuple<string, string, string, string>>();
            int i, j;
            Cell cell;
            for (i = 0; (i <= (Sheet.Worksheets[0].RowCount - 1)); i++)
            {
                for (j = 0; (j <= (Sheet.Worksheets[0].ColumnCount - 1)); j++)
                {
                    cell = Sheet.Worksheets[0].Cells[i, j];
                    ccparams = (SpreadsheetCellParameters)cell.Tag;
                    if (!(ccparams == null))
                    {
                        var expression = ccparams.Expression;
                        switch (ccparams.CellType)
                        {
                            case SharedClasses.Spreadsheet.VarType.Expression:
                            case SharedClasses.Spreadsheet.VarType.Read:
                                if ((expression != ""))
                                {
                                    if ((expression.Substring(0, 1) == "="))
                                    {
                                        cell.Formula = expression.TrimStart('=').ToUpper();
                                        cell.Style.BackColor = Colors.LightYellow.ToSolidColor();
                                    }
                                    else if ((expression.Substring(0, 1) == ":"))
                                    {
                                        string[] str;
                                        string obj;
                                        string prop;
                                        str = expression.Split(new char[] { ',' });
                                        obj = str[0].Substring(1);
                                        ccparams.ObjectID = obj;
                                        if ((str.Length < 3))
                                        {
                                            prop = str[1];
                                        }
                                        else
                                        {
                                            prop = (str[1] + ("," + str[2]));
                                        }
                                        ccparams.PropID = prop;
                                        cell.Formula = string.Format("GETPROPVAL({3}{0}{3}{1}{3}{2}{3})", obj, separator, prop, '\"');
                                        cell.Style.BackColor = Colors.LightGreen.ToSolidColor();
                                    }
                                    else
                                    {
                                        cell.Data = expression;
                                        if (((ccparams.CellType != SharedClasses.Spreadsheet.VarType.Write)
                                                    && (ccparams.CellType != SharedClasses.Spreadsheet.VarType.Unit)))
                                        {
                                            ccparams.ToolTipText = expression;
                                        }

                                    }
                                }
                                break;
                            case SharedClasses.Spreadsheet.VarType.Unit:
                                cell.Style.BackColor = Colors.Beige.ToSolidColor();
                                break;
                            case SharedClasses.Spreadsheet.VarType.Write:
                                if ((expression.Substring(0, 1) == "="))
                                {
                                    cell.Formula = expression.TrimStart('=').ToUpper();
                                    if (!(ccparams.CellType == SharedClasses.Spreadsheet.VarType.Write))
                                    {
                                        cell.Style.BackColor = Colors.LightYellow.ToSolidColor();
                                    }
                                    else
                                    {
                                        cell.Data = expression;
                                        if (((ccparams.CellType != SharedClasses.Spreadsheet.VarType.Write)
                                                    && (ccparams.CellType != SharedClasses.Spreadsheet.VarType.Unit)))
                                        {
                                            ccparams.ToolTipText = expression;
                                        }

                                    }

                                    elist.Add(new Tuple<string, string, string, string>(string.Format("SETPROPVAL({4}{1}{4}{0}{4}{2}{4}{0}{4}{3}{4})", separator, ccparams.ObjectID, ccparams.PropID, ("MAIN!" + cell.Address), '\"'), ccparams.ObjectID, ccparams.PropID, ccparams.PropUnit));
                                    cell.Style.BackColor = Colors.LightBlue.ToSolidColor();
                                }
                                break;
                        }
                    }
                }
            }

            esheet.Cells[0, 0].Data = "EXPRESSION";
            esheet.Cells[0, 1].Data = "OBJECT";
            esheet.Cells[0, 2].Data = "PROPERTY";
            esheet.Cells[0, 3].Data = "UNITS";

            esheet.Cells[0, 0].Style.Bold = true;
            esheet.Cells[0, 1].Style.Bold = true;
            esheet.Cells[0, 2].Style.Bold = true;
            esheet.Cells[0, 3].Style.Bold = true;

            i = 1;
            foreach (var item in elist)
            {
                esheet.Cells[i, 0].Formula = item.Item1;
                esheet.Cells[i, 1].Data = flowsheet.SimulationObjects[item.Item2].GraphicObject.Tag;
                esheet.Cells[i, 2].Data = item.Item3;
                esheet.Cells[i, 3].Data = item.Item4;
            }

        }

        void SetCustomFunctions()
        {
            CrossPlatform.UI.Controls.ReoGrid.Formula.FormulaExtension.CustomFunctions["GETPROPVAL"] = (cell, args) =>
            {
                if (args.Length == 2)
                {
                    try
                    {
                        return flowsheet.SimulationObjects[args[0].ToString()].GetPropertyValue(args[1].ToString());
                    }
                    catch (Exception ex)
                    {
                        return "ERROR: " + ex.Message;
                    }
                }
                else if (args.Length == 3)
                {
                    try
                    {
                        var obj = flowsheet.SimulationObjects[args[0].ToString()];
                        var val = obj.GetPropertyValue(args[1].ToString());
                        return General.ConvertUnits(double.Parse(val.ToString()), obj.GetPropertyUnit(args[1].ToString()), args[2].ToString());
                    }
                    catch (Exception ex)
                    {
                        return "ERROR: " + ex.Message;
                    }
                }
                else
                    return "INVALID ARGS";
            };

            CrossPlatform.UI.Controls.ReoGrid.Formula.FormulaExtension.CustomFunctions["SETPROPVAL"] = (cell, args) =>
            {
                if (args.Length == 3)
                {
                    try
                    {
                        if (Loaded)
                        {
                            var ws = cell.Worksheet;
                            var wcell = ws.Cells[ws.RowCount - 1, ws.ColumnCount - 1];
                            wcell.Formula = args[2].ToString().Trim('"');
                            Evaluator.Evaluate(wcell);
                            var val = wcell.Data;
                            flowsheet.SimulationObjects[args[0].ToString()].SetPropertyValue(args[1].ToString(), val);
                            wcell.Formula = "";
                            wcell.Data = "";
                            return string.Format("EXPORT OK [{0}, {1} = {2}]", flowsheet.SimulationObjects[args[0].ToString()].GraphicObject.Tag, args[1].ToString(), val);
                        }
                        else
                        {
                            return "NOT READY";
                        }
                    }
                    catch (Exception ex)
                    {
                        return "ERROR: " + ex.Message;
                    }
                }
                else if (args.Length == 4)
                {
                    try
                    {
                        if (Loaded)
                        {
                            var obj = flowsheet.SimulationObjects[args[0].ToString()];
                            var prop = args[1].ToString();
                            var ws = cell.Worksheet;
                            var wcell = ws.Cells[ws.RowCount - 1, ws.ColumnCount - 1];
                            wcell.Formula = args[2].ToString().Trim('"');
                            Evaluator.Evaluate(wcell);
                            var val = wcell.Data;
                            wcell.Formula = "";
                            wcell.Data = "";
                            var units = args[3].ToString();
                            var newval = General.ConvertUnits(double.Parse(val.ToString()), units, obj.GetPropertyUnit(prop));
                            obj.SetPropertyValue(prop, newval);
                            return string.Format("EXPORT OK [{0}, {1} = {2} {3}]", obj.GraphicObject.Tag, prop, val, units);
                        }
                        else
                        {
                            return "NOT READY";
                        }
                    }
                    catch (Exception ex)
                    {
                        return "ERROR: " + ex.Message;
                    }
                }
                else
                    return "INVALID ARGS";
            };

            CrossPlatform.UI.Controls.ReoGrid.Formula.FormulaExtension.CustomFunctions["GETPROPUNITS"] = (cell, args) =>
            {
                if (args.Length == 2)
                {
                    try
                    {
                        return flowsheet.SimulationObjects[args[0].ToString()].GetPropertyUnit(args[1].ToString());
                    }
                    catch (Exception ex)
                    {
                        return "ERROR: " + ex.Message;
                    }
                }
                else
                    return "INVALID ARGS";
            };

            CrossPlatform.UI.Controls.ReoGrid.Formula.FormulaExtension.CustomFunctions["GETOBJID"] = (cell, args) =>
            {
                if (args.Length == 1)
                {
                    try
                    {
                        return flowsheet.GetFlowsheetSimulationObject(args[0].ToString()).Name;
                    }
                    catch (Exception ex)
                    {
                        return "ERROR: " + ex.Message;
                    }
                }
                else
                    return "INVALID ARGS";
            };

            CrossPlatform.UI.Controls.ReoGrid.Formula.FormulaExtension.CustomFunctions["GETOBJNAME"] = (cell, args) =>
            {
                if (args.Length == 1)
                {
                    try
                    {
                        return flowsheet.SimulationObjects[args[0].ToString()].GraphicObject.Tag;
                    }
                    catch (Exception ex)
                    {
                        return "ERROR: " + ex.Message;
                    }
                }
                else
                    return "INVALID ARGS";
            };
        }
    }

}