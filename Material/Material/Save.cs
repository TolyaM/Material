using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Windows.Threading;
using Маркетинг;
using Word = Microsoft.Office.Interop.Word;


namespace Material
{
    class Save
    {
        Excel ex = new Excel();

        public ObservableCollection<string> YubkaFirst = new ObservableCollection<string>();
        public ObservableCollection<string> YubkaSecond = new ObservableCollection<string>();

        public ObservableCollection<string> PaltoFirst = new ObservableCollection<string>();
        public ObservableCollection<string> PaltoSecond = new ObservableCollection<string>();

        public ObservableCollection<string> BrykiFirst = new ObservableCollection<string>();
        public ObservableCollection<string> BrykiSecond = new ObservableCollection<string>();

        Word.Application wordApplication = new Word.Application();

        public Save()
        {
            Fill();
        }

        void Fill()
        {
            YubkaFirst.Add("1");
            YubkaSecond.Add("41 - 91");

            YubkaFirst.Add("2");
            YubkaSecond.Add("41 - 51");

            YubkaFirst.Add("3");
            YubkaSecond.Add("51 - 57");

            YubkaFirst.Add("4");
            YubkaSecond.Add("51 - 54");

            YubkaFirst.Add("5");
            YubkaSecond.Add("94 - 441");

            YubkaFirst.Add("6");
            YubkaSecond.Add("97 - 47");

            YubkaFirst.Add("7");
            YubkaSecond.Add("41 - 470");

            YubkaFirst.Add("7.1");
            YubkaSecond.Add("470 - 47 (dt)");

            YubkaFirst.Add("8");
            YubkaSecond.Add("41 - 420");

            YubkaFirst.Add("9");
            YubkaSecond.Add("47 - 460");

            YubkaFirst.Add("10");
            YubkaSecond.Add("441 - 442");

            YubkaFirst.Add("10.1");
            YubkaSecond.Add("441 - 442`");

            YubkaFirst.Add("11");
            YubkaSecond.Add("41 - 42");

            YubkaFirst.Add("11.1");
            YubkaSecond.Add("42 - 521");

            YubkaFirst.Add("11.2");
            YubkaSecond.Add("42 - 421`");

            YubkaFirst.Add("11.3");
            YubkaSecond.Add("42 - 421");

            YubkaFirst.Add("12");
            YubkaSecond.Add("47 - 46");

            YubkaFirst.Add("12.1");
            YubkaSecond.Add("46 - 561");

            YubkaFirst.Add("12.2");
            YubkaSecond.Add("46 - 461");

            YubkaFirst.Add("12.3");
            YubkaSecond.Add("46 - 461`");

            YubkaFirst.Add("12.4");
            YubkaSecond.Add("41 - 42");

            YubkaFirst.Add("12.5");
            YubkaSecond.Add("41 - 43");

            YubkaFirst.Add("12.6");
            YubkaSecond.Add("47 - 45");

            YubkaFirst.Add("12.7");
            YubkaSecond.Add("42 - 421`");

            YubkaFirst.Add("12.8");
            YubkaSecond.Add("42 - 421");

            YubkaFirst.Add("12.9");
            YubkaSecond.Add("42 - 521");

            YubkaFirst.Add("12.10");
            YubkaSecond.Add("43 - 431");

            YubkaFirst.Add("12.11");
            YubkaSecond.Add("43 - 431`");

            YubkaFirst.Add("12.12");
            YubkaSecond.Add("43 - 531");

            YubkaFirst.Add("12.13");
            YubkaSecond.Add("45 - 451");

            YubkaFirst.Add("12.14");
            YubkaSecond.Add("45 - 451`");

            YubkaFirst.Add("12.15");
            YubkaSecond.Add("45 - 551");

            PaltoFirst.Add("1");
            PaltoSecond.Add(" 11 - 91 ");

            PaltoFirst.Add("2");
            PaltoSecond.Add(" 11 - 21 ");

            PaltoFirst.Add("3");
            PaltoSecond.Add(" 11 - 31 ");

            PaltoFirst.Add("4");
            PaltoSecond.Add(" 11 - 41 ");

            PaltoFirst.Add("5");
            PaltoSecond.Add("41 - 51");

            PaltoFirst.Add("6");
            PaltoSecond.Add("31 - 33");

            PaltoFirst.Add("7");
            PaltoSecond.Add("33 - 35");

            PaltoFirst.Add("8");
            PaltoSecond.Add("35 - 37");

            PaltoFirst.Add("9");
            PaltoSecond.Add("31 - 37");

            PaltoFirst.Add("10");
            PaltoSecond.Add("37 - 37");

            PaltoFirst.Add("11");
            PaltoSecond.Add("47 - 57");

            PaltoFirst.Add("12");
            PaltoSecond.Add("47 - 97");

            PaltoFirst.Add("13");
            PaltoSecond.Add("33 - 13");

            PaltoFirst.Add("14");
            PaltoSecond.Add("35 - 15");

            PaltoFirst.Add("17");
            PaltoSecond.Add("331 - 311");

            PaltoFirst.Add("18");
            PaltoSecond.Add("351 - 311");

            PaltoFirst.Add("20.1");
            PaltoSecond.Add("R 341 - 342");

            PaltoFirst.Add("21");
            PaltoSecond.Add("351 - 352");

            PaltoFirst.Add("27");
            PaltoSecond.Add("11 - 12");

            PaltoFirst.Add("28");
            PaltoSecond.Add("11 - 112");

            PaltoFirst.Add("29");
            PaltoSecond.Add("12 - 121");

            PaltoFirst.Add("30");
            PaltoSecond.Add("13 - 14");

            PaltoFirst.Add("32");
            PaltoSecond.Add("31 - 32");

            PaltoFirst.Add("34");
            PaltoSecond.Add("∡ 122-22-122");

            PaltoFirst.Add("39");
            PaltoSecond.Add("R 121 - 114");

            PaltoFirst.Add("39.1");
            PaltoSecond.Add("R 112 - 114");

            PaltoFirst.Add("45");
            PaltoSecond.Add("47 - 46");

            PaltoFirst.Add("47");
            PaltoSecond.Add("46 - 36");

            PaltoFirst.Add("48");
            PaltoSecond.Add("36 - 371");

            PaltoFirst.Add("50.1");
            PaltoSecond.Add("372 - 372`");

            PaltoFirst.Add("51");
            PaltoSecond.Add("371` - 361");

            PaltoFirst.Add("52");
            PaltoSecond.Add("R 36 - 16");

            PaltoFirst.Add("54");
            PaltoSecond.Add("16 - 161");

            PaltoFirst.Add("61");
            PaltoSecond.Add("411 - 470");

            PaltoFirst.Add("62");
            PaltoSecond.Add("511 - 570");

            PaltoFirst.Add("63.1");
            PaltoSecond.Add("ДП");

            PaltoFirst.Add("63.2");
            PaltoSecond.Add("ПОР");

            PaltoFirst.Add("63.3");
            PaltoSecond.Add("ДОР");

            PaltoFirst.Add("64");
            PaltoSecond.Add("331 - 351");

            PaltoFirst.Add("65");
            PaltoSecond.Add("331 - 341");

            PaltoFirst.Add("69");
            PaltoSecond.Add("351 - 352");

            PaltoFirst.Add("70");
            PaltoSecond.Add("R 352 - 343");

            PaltoFirst.Add("70.1");
            PaltoSecond.Add("R 341` - 343");

            PaltoFirst.Add("70.2");
            PaltoSecond.Add("341 - 352");

            PaltoFirst.Add("71");
            PaltoSecond.Add("351 - 333 (ШОР)");

            PaltoFirst.Add("72");
            PaltoSecond.Add("333 - 13 (ВОР)");

            PaltoFirst.Add("90");
            PaltoSecond.Add("95 - 931");

            PaltoFirst.Add("91");
            PaltoSecond.Add("95 - 94");

            BrykiFirst.Add("1");
            BrykiSecond.Add("41 - 51");

            BrykiFirst.Add("2");
            BrykiSecond.Add("51 - 57");

            BrykiFirst.Add("3");
            BrykiSecond.Add("51 - 54");

            BrykiFirst.Add("4");
            BrykiSecond.Add("54` - 57");

            BrykiFirst.Add("5");
            BrykiSecond.Add("44` - 940");

            BrykiFirst.Add("6");
            BrykiSecond.Add("940 - 441`");

            BrykiFirst.Add("7");
            BrykiSecond.Add("940 - 440");

            BrykiFirst.Add("8");
            BrykiSecond.Add("940 - 64");

            BrykiFirst.Add("9");
            BrykiSecond.Add("940 - 74");

            BrykiFirst.Add("10");
            BrykiSecond.Add("940 - 94");

            BrykiFirst.Add("11");
            BrykiSecond.Add("51 - 58");

            BrykiFirst.Add("12");
            BrykiSecond.Add("57 - 58`");

            BrykiFirst.Add("13");
            BrykiSecond.Add("58 - 52");

            BrykiFirst.Add("14");
            BrykiSecond.Add("54` - 56");

            BrykiFirst.Add("15");
            BrykiSecond.Add("72 - 78");

            BrykiFirst.Add("16");
            BrykiSecond.Add("72 - 741");

            BrykiFirst.Add("17");
            BrykiSecond.Add("76 - 741`");

            BrykiFirst.Add("18");
            BrykiSecond.Add("76 - 78`");

            BrykiFirst.Add("19");
            BrykiSecond.Add("92 - 98");

            BrykiFirst.Add("20");
            BrykiSecond.Add("92 - 941");

            BrykiFirst.Add("21");
            BrykiSecond.Add("96 - 941`");

            BrykiFirst.Add("22");
            BrykiSecond.Add("96 - 98");

            BrykiFirst.Add("23");
            BrykiSecond.Add("41 - 470");

            BrykiFirst.Add("31");
            BrykiSecond.Add("68 - 681");

            BrykiFirst.Add("32.2");
            BrykiSecond.Add("681 - 512");

            BrykiFirst.Add("34.2");
            BrykiSecond.Add("68` - 57");

            BrykiFirst.Add("35");
            BrykiSecond.Add("470 - 47 (dt)");

            BrykiFirst.Add("38");
            BrykiSecond.Add("441 - 420");

            BrykiFirst.Add("38.1");
            BrykiSecond.Add("441 - 442");

            BrykiFirst.Add("39");
            BrykiSecond.Add("47 - 471");

            BrykiFirst.Add("40");
            BrykiSecond.Add("411 - 421");

            BrykiFirst.Add("40.1");
            BrykiSecond.Add("421 - 521");

            BrykiFirst.Add("40.2");
            BrykiSecond.Add("421 - 422");

            BrykiFirst.Add("40.3");
            BrykiSecond.Add("421 - 422");

            BrykiFirst.Add("41");
            BrykiSecond.Add("411 - 43");

            BrykiFirst.Add("41.1");
            BrykiSecond.Add("43 - 531");

            BrykiFirst.Add("41.2");
            BrykiSecond.Add("43 - 431");

            BrykiFirst.Add("41.3");
            BrykiSecond.Add("43 - 431`");

            BrykiFirst.Add("42");
            BrykiSecond.Add("46 - 561");

            BrykiFirst.Add("42.1");
            BrykiSecond.Add("46 - 461");

            BrykiFirst.Add("42.2");
            BrykiSecond.Add("46 - 461`");
        }

        public void StartBehavior(ToggleButton All, ToggleButton YubkaSave, ToggleButton PaltoSave, ToggleButton BrykiSave, bool YubkaCalculationChecked, bool PaltoCalculationChecked, bool BrykiCalculationChecked)
        {
            if (!YubkaCalculationChecked) YubkaSave.IsEnabled = true;
            if (!PaltoCalculationChecked) PaltoSave.IsEnabled = true;
            if (!BrykiCalculationChecked) BrykiSave.IsEnabled = true;

            if (YubkaCalculationChecked)
            {
                YubkaSave.IsEnabled = false;
                YubkaSave.IsChecked = false;
            }
            if (PaltoCalculationChecked)
            {
                PaltoSave.IsEnabled = false;
                PaltoSave.IsChecked = false;
            }
            if (BrykiCalculationChecked)
            {
                BrykiSave.IsEnabled = false;
                BrykiSave.IsChecked = false;
            }       
        }    

        void ExcelMethod(int Position, int HeadPos, ToggleButton Save, ObservableCollection<string> First, ObservableCollection<string> Second, ObservableCollection<string> Formula, ObservableCollection<double> Answer)
        {
            string A = Position == 1 ? (A = "A") : Position == 2 ? (A = "F") : Position == 3 ? (A = "K") : (A = "A");
            string B = Position == 1 ? (B = "B") : Position == 2 ? (B = "G") : Position == 3 ? (B = "L") : (B = "B");
            string C = Position == 1 ? (C = "C") : Position == 2 ? (C = "H") : Position == 3 ? (C = "M") : (C = "C");
            string D = Position == 1 ? (D = "D") : Position == 2 ? (D = "I") : Position == 3 ? (D = "N") : (D = "D");

            string Header = HeadPos == 1 ? (Header = "Юбка") : HeadPos == 2 ? (Header = "Пальто") : HeadPos == 3 ? (Header = "Брюки") : (Header = String.Empty);

            ex.SetValue(A + 1, Header);

            ex.SetColumnWidth(A + 2, 22); ex.SetRowHeight(A + 2, 20); ex.SetBorderStyle(A + 2, 2); ex.SetHorisontalAlignment(A + 2, 3);
            ex.SetColumnWidth(B + 2, 22); ex.SetRowHeight(B + 2, 20); ex.SetBorderStyle(B + 2, 2); ex.SetHorisontalAlignment(B + 2, 3);
            ex.SetColumnWidth(C + 2, 35); ex.SetRowHeight(C + 2, 35); ex.SetBorderStyle(C + 2, 2); ex.SetHorisontalAlignment(C + 2, 3);
            ex.SetColumnWidth(D + 2, 22); ex.SetRowHeight(D + 2, 20); ex.SetBorderStyle(D + 2, 2); ex.SetHorisontalAlignment(D + 2, 3);

            ex.SetValue(A + 2, "Номер системы");
            ex.SetValue(B + 2, "Отрезок");
            ex.SetValue(C + 2, "Формула");
            ex.SetValue(D + 2, "Ответ");

            for (int i = 2; i < Answer.Count + 2; i++)
            {
                ex.SetValue(A + (i + 1), First[i - 2].ToString());
                ex.SetValue(B + (i + 1), Second[i - 2].ToString());
                ex.SetValue(C + (i + 1), Formula[i - 2].ToString());
                ex.SetValue(D + (i + 1), Answer[i - 2].ToString());

                ex.SetRowHeight(A + (i + 1), 20);
                ex.SetRowHeight(B + (i + 1), 20);
                ex.SetRowHeight(C + (i + 1), 20);
                ex.SetRowHeight(D + (i + 1), 20);

                ex.SetBorderStyle(A + (i + 1), 2);
                ex.SetBorderStyle(B + (i + 1), 2);
                ex.SetBorderStyle(C + (i + 1), 2);
                ex.SetBorderStyle(D + (i + 1), 2);

                ex.SetHorisontalAlignment(A + (i + 1), 3);
                ex.SetHorisontalAlignment(B + (i + 1), 3);
                ex.SetHorisontalAlignment(C + (i + 1), 3);
                ex.SetHorisontalAlignment(D + (i + 1), 3);
            }
        }
     
        public void SaveExcel(ToggleButton All, ToggleButton YubkaSave, ToggleButton PaltoSave, ToggleButton BrykiSave, ObservableCollection<string> Formula, ObservableCollection<double> Answer, ObservableCollection<string> FormulaP, ObservableCollection<double> AnswerP, ObservableCollection<string> FormulaB, ObservableCollection<double> AnswerB)
        {
            bool[] flag = new bool[3];
            ex.NewDocument();

            var isYubkaChecked = (bool)YubkaSave.Dispatcher.Invoke(new Func<bool?>(() => YubkaSave.IsChecked));
            var isPaltoChecked = (bool)PaltoSave.Dispatcher.Invoke(new Func<bool?>(() => PaltoSave.IsChecked));
            var isBrykiChecked = (bool)BrykiSave.Dispatcher.Invoke(new Func<bool?>(() => BrykiSave.IsChecked));
            var isAllChecked = (bool)All.Dispatcher.Invoke(new Func<bool?>(() => All.IsChecked));

            if (isYubkaChecked)
            {
                ExcelMethod(1, 1, YubkaSave,YubkaFirst, YubkaSecond, Formula, Answer);
            }

            if (isPaltoChecked)
            {
                ExcelMethod(1, 2, PaltoSave, PaltoFirst, PaltoSecond, FormulaP, AnswerP);
            }

            if (isBrykiChecked)
            {
                ExcelMethod(1, 3, BrykiSave, BrykiFirst, BrykiSecond, FormulaB, AnswerB);
            }

            if (isAllChecked)
            {
                flag[0] = (bool)YubkaSave.Dispatcher.Invoke(new Func<bool?>(() => YubkaSave.IsEnabled == true)) ? (flag[0] = true) : (flag[0] = false);
                flag[1] = (bool)PaltoSave.Dispatcher.Invoke(new Func<bool?>(() => PaltoSave.IsEnabled == true)) ? (flag[1] = true) : (flag[1] = false);
                flag[2] = (bool)BrykiSave.Dispatcher.Invoke(new Func<bool?>(() => BrykiSave.IsEnabled == true)) ? (flag[2] = true) : (flag[2] = false);
                
                if(flag[0] && flag[1] && flag[2])
                {
                    ExcelMethod(1, 1, YubkaSave, YubkaFirst, YubkaSecond, Formula, Answer);
                    ExcelMethod(2, 2, PaltoSave, PaltoFirst, PaltoSecond, FormulaP, AnswerP);
                    ExcelMethod(3, 3, BrykiSave, BrykiFirst, BrykiSecond, FormulaB, AnswerB);
                }

                if (flag[0] && !flag[1] && !flag[2]) ExcelMethod(1, 1, YubkaSave, YubkaFirst, YubkaSecond, Formula, Answer);
                if (!flag[0] && flag[1] && !flag[2]) ExcelMethod(1, 2, PaltoSave, PaltoFirst, PaltoSecond, FormulaP, AnswerP);
                if (!flag[0] && !flag[1] && flag[2]) ExcelMethod(1, 3, BrykiSave, BrykiFirst, BrykiSecond, FormulaB, AnswerB);

                if (flag[0] && flag[1] && !flag[2])
                {
                    ExcelMethod(1, 1, YubkaSave, YubkaFirst, YubkaSecond, Formula, Answer);
                    ExcelMethod(2, 2, PaltoSave, PaltoFirst, PaltoSecond, FormulaP, AnswerP);
                }

                if (flag[0] && !flag[1] && flag[2])
                {
                    ExcelMethod(1, 1, YubkaSave, YubkaFirst, YubkaSecond, Formula, Answer);
                    ExcelMethod(2, 3, BrykiSave, BrykiFirst, BrykiSecond, FormulaB, AnswerB);
                }

                if (!flag[0] && flag[1] && flag[2])
                {
                    ExcelMethod(1, 2, PaltoSave, PaltoFirst, PaltoSecond, FormulaP, AnswerP);
                    ExcelMethod(2, 3, BrykiSave, BrykiFirst, BrykiSecond, FormulaB, AnswerB);
                }
            }

            ex.Visible = true;

        }

        void WordMethod(int Position, ToggleButton Save, ObservableCollection<string> First, ObservableCollection<string> Second, ObservableCollection<string> Formula, ObservableCollection<double> Answer)
        {
            Object template = Type.Missing;
            Object newTemplate = Type.Missing;
            Object documentType = Type.Missing;
            Object visible = Type.Missing;
                
            wordApplication.Documents.Add(ref template, ref newTemplate, ref documentType, ref visible);//добавили в проложение документ
            Word.Document doc = wordApplication.ActiveDocument;
            wordApplication.Visible = true; //делаем что бы word не работал в фоновом режиме
            Object r = Type.Missing;
            Word.Paragraph par = doc.Content.Paragraphs.Add(ref r);//дабавляем в документ параграф

            par.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

            Object missing = 0;
            Word.Range rng = doc.Range(ref missing, ref missing); //получаем текстовую область параграфа
            string Header = Position == 1 ? (Header = "Юбка") : Position == 2 ? (Header = "Пальто") : Position == 3 ? (Header = "Брюки") : (Header = String.Empty);
            rng.Text = Header;
            rng.Font.Size = 15;
            rng.Font.Bold = 2;
            missing = Type.Missing;

            rng.Tables.Add(doc.Paragraphs[doc.Paragraphs.Count].Range, Answer.Count, 4, ref missing, ref missing);//вставляем в текстовую область таблицу
            Word.Table tbl = doc.Tables[doc.Tables.Count];//для удобства работы присваиваем таблицу переменной

            tbl.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
            tbl.Range.Font.Size = 10;


            tbl.Cell(1, 1).Range.Text = "Номер системы"; 
            tbl.Cell(1, 2).Range.Text = "Отрезок";
            tbl.Cell(1, 3).Range.Text = "Формула";
            tbl.Cell(1, 4).Range.Text = "Ответ";

            for (int i = 2; i < Answer.Count + 2; i++)
            {
                tbl.Cell(i, 1).Range.Text = First[i - 2]; 
                tbl.Cell(i, 2).Range.Text = Second[i - 2]; 
                tbl.Cell(i, 3).Range.Text = Formula[i - 2].ToString(); 
                tbl.Cell(i, 4).Range.Text = Answer[i - 2].ToString(); 
            }

            Word.Border[] borders = new Word.Border[6];//массив бордеров
            borders[0] = tbl.Borders[Word.WdBorderType.wdBorderLeft];//левая граница 
            borders[1] = tbl.Borders[Word.WdBorderType.wdBorderRight];//правая граница 
            borders[2] = tbl.Borders[Word.WdBorderType.wdBorderTop];//нижняя граница 
            borders[3] = tbl.Borders[Word.WdBorderType.wdBorderBottom];//верхняя граница
            borders[4] = tbl.Borders[Word.WdBorderType.wdBorderHorizontal];//горизонтальная граница
            borders[5] = tbl.Borders[Word.WdBorderType.wdBorderVertical];//вертикальная граница
            foreach (Word.Border border in borders)
            {
                border.LineStyle = Word.WdLineStyle.wdLineStyleSingle;//ставим стиль границы 
                border.Color = Word.WdColor.wdColorBlack;//задаем цвет границы
            }
        }

        public void SaveWord(ToggleButton All, ToggleButton YubkaSave, ToggleButton PaltoSave, ToggleButton BrykiSave, ObservableCollection<string> Formula, ObservableCollection<double> Answer, ObservableCollection<string> FormulaP, ObservableCollection<double> AnswerP, ObservableCollection<string> FormulaB, ObservableCollection<double> AnswerB)
        {
            bool[] flag = new bool[3];

            var isYubkaChecked = (bool)YubkaSave.Dispatcher.Invoke(new Func<bool?>(() => YubkaSave.IsChecked));
            var isPaltoChecked = (bool)PaltoSave.Dispatcher.Invoke(new Func<bool?>(() => PaltoSave.IsChecked));
            var isBrykiChecked = (bool)BrykiSave.Dispatcher.Invoke(new Func<bool?>(() => BrykiSave.IsChecked));
            var isAllChecked = (bool)All.Dispatcher.Invoke(new Func<bool?>(() => All.IsChecked));

            if (isYubkaChecked)
            {
                WordMethod(1, YubkaSave, YubkaFirst, YubkaSecond, Formula, Answer);
            }

            if (isPaltoChecked)
            {
                WordMethod(2, PaltoSave, PaltoFirst, PaltoSecond, FormulaP, AnswerP);
            }

            if (isBrykiChecked)
            {
                WordMethod(3, BrykiSave, BrykiFirst, BrykiSecond, FormulaB, AnswerB);
            }

            if (isAllChecked)
            {
                flag[0] = (bool)YubkaSave.Dispatcher.Invoke(new Func<bool?>(() => YubkaSave.IsEnabled == true)) ? (flag[0] = true) : (flag[0] = false);
                flag[1] = (bool)PaltoSave.Dispatcher.Invoke(new Func<bool?>(() => PaltoSave.IsEnabled == true)) ? (flag[1] = true) : (flag[1] = false);
                flag[2] = (bool)BrykiSave.Dispatcher.Invoke(new Func<bool?>(() => BrykiSave.IsEnabled == true)) ? (flag[2] = true) : (flag[2] = false);

                if (flag[0] && flag[1] && flag[2])
                {
                    WordMethod(1, YubkaSave, YubkaFirst, YubkaSecond, Formula, Answer);
                    WordMethod(2, PaltoSave, PaltoFirst, PaltoSecond, FormulaP, AnswerP);
                    WordMethod(3, BrykiSave, BrykiFirst, BrykiSecond, FormulaB, AnswerB);
                }

                if (flag[0] && !flag[1] && !flag[2]) WordMethod(1, YubkaSave, YubkaFirst, YubkaSecond, Formula, Answer);
                if (!flag[0] && flag[1] && !flag[2]) WordMethod(2, PaltoSave, PaltoFirst, PaltoSecond, FormulaP, AnswerP);
                if (!flag[0] && !flag[1] && flag[2]) WordMethod(3, BrykiSave, BrykiFirst, BrykiSecond, FormulaB, AnswerB);

                if (flag[0] && flag[1] && !flag[2])
                {
                    WordMethod(1, YubkaSave, YubkaFirst, YubkaSecond, Formula, Answer);
                    WordMethod(2, PaltoSave, PaltoFirst, PaltoSecond, FormulaP, AnswerP);
                }

                if (flag[0] && !flag[1] && flag[2])
                {
                    WordMethod(1, YubkaSave, YubkaFirst, YubkaSecond, Formula, Answer);
                    WordMethod(3, BrykiSave, BrykiFirst, BrykiSecond, FormulaB, AnswerB);
                }

                if (!flag[0] && flag[1] && flag[2])
                {
                    WordMethod(2, PaltoSave, PaltoFirst, PaltoSecond, FormulaP, AnswerP);
                    WordMethod(3, BrykiSave, BrykiFirst, BrykiSecond, FormulaB, AnswerB);
                }
            }
        }
    }
}
