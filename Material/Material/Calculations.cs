using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Material
{
    public class Calculations
    {

        public ObservableCollection<double> Answer;
        public ObservableCollection<string> Formula;

        public ObservableCollection<double> AnswerP;
        public ObservableCollection<string> FormulaP;

        public ObservableCollection<double> AnswerB;
        public ObservableCollection<string> FormulaB;

        public bool[] CalculationIsGet = new bool[3]; 

        public Calculations()
        {
            Answer = new ObservableCollection<double>();
            Formula = new ObservableCollection<string>();

            AnswerP = new ObservableCollection<double>();
            FormulaP = new ObservableCollection<string>();

            AnswerB = new ObservableCollection<double>();
            FormulaB = new ObservableCollection<string>();

            CalculationIsGet[0] = false; CalculationIsGet[1] = false; CalculationIsGet[2] = false;
        }

        public void YubkaData(TextBox T7, TextBox T9, TextBox T12, TextBox T18, TextBox T19, TextBox T25, TextBox T26, TextBox T46, TextBox П4191, TextBox П5157, TextBox П94441, TextBox П9747, TextBox П41470, TextBox П47047dt) //Сделать асинхронным
        {
            CalculationIsGet[0] = true;
            Answer = new ObservableCollection<double>();
            Formula = new ObservableCollection<string>();

            Answer.Add(Math.Round(Convert.ToDouble(T7.Text) - Convert.ToDouble(T9.Text) + 0.75 + Convert.ToDouble(П4191.Text),2));
            Formula.Add(T7.Text + " - " + T9.Text + " + " + 0.75.ToString() + " + " + П4191.Text);

            Answer.Add(Math.Round(0.65 * (Convert.ToDouble(T7.Text) - Convert.ToDouble(T12.Text)) + 0.75,2));
            Formula.Add("0.65 * (" + T7.Text + " - " + T12.Text + ") + " + "0.75");

            Answer.Add(Math.Round(0.5 * Convert.ToDouble(T19.Text) + Convert.ToDouble((П5157.Text)),2));
            Formula.Add("0.5 * " + T19.Text + " + " + П5157.Text);

            Answer.Add(Math.Round(0.5 * Answer[2],2));
            Formula.Add("0.5 * " + Answer[2].ToString());

            Answer.Add(Math.Round(Convert.ToDouble(T25.Text) - Convert.ToDouble(T9.Text) - 0.3 + Convert.ToDouble(П94441.Text),2));
            Formula.Add(T25.Text + " - " + T9.Text + " - 0.3 + " + П94441.Text);

            Answer.Add(Math.Round(Convert.ToDouble(T26.Text) - Convert.ToDouble(T9.Text) + Convert.ToDouble(П9747.Text),2));
            Formula.Add(T26.Text + " - " + T9.Text + " + " + П9747.Text);

            Answer.Add(Math.Round(0.5 * Convert.ToDouble(T18.Text) + Convert.ToDouble(П41470.Text),2));
            Formula.Add("0.5 * " + T18.Text + " + " + П41470.Text);

            Answer.Add(Math.Round((0.5 * Convert.ToDouble(T19.Text) + Convert.ToDouble(П47047dt.Text)) - (0.5 * Convert.ToDouble(T18.Text) + Convert.ToDouble(П47047dt.Text)),2));
            Formula.Add("(0.5 * " + T19.Text + " + " + П47047dt.Text + ") - (0.5 * " + T18.Text + " + " + П47047dt.Text + ")");

            Answer.Add(Math.Round(0.1 * Convert.ToDouble(Answer[6]),2));
            Formula.Add("0.1 * " + Answer[6].ToString());

            Answer.Add(Math.Round(0.1 * Convert.ToDouble(Answer[6]),2));
            Formula.Add("0.1 * " + Answer[6].ToString());

            Answer.Add(Math.Round(0.26 * Convert.ToDouble(Answer[7]),2));
            Formula.Add("0.26 * " + Answer[7].ToString());

            Answer.Add(Math.Round(0.26 * Convert.ToDouble(Answer[7]),2));
            Formula.Add("0.26 * " + Answer[7].ToString());

            Answer.Add(Math.Round(0.4 * Convert.ToDouble(Answer[3]),2));
            Formula.Add("0.4 * " + Answer[3].ToString());

            Answer.Add(Math.Round(0.8 * Convert.ToDouble(Answer[1]),2));
            Formula.Add("0.8 * " + Answer[1].ToString());

            Answer.Add(Math.Round(0.17 * Convert.ToDouble(Answer[7]),2));
            Formula.Add("0.17 * " + Answer[7].ToString());

            Answer.Add(Math.Round(0.17 * Convert.ToDouble(Answer[7]),2));
            Formula.Add("0.17 * " + Answer[7].ToString());

            Answer.Add(Math.Round(0.5 * Convert.ToDouble(T46.Text),2));
            Formula.Add("0.5 * " + T46.Text);

            Answer.Add(Math.Round(0.5 * Convert.ToDouble(Answer[1]),2));
            Formula.Add("0.5 * " + Answer[1].ToString());

            Answer.Add(Math.Round(0.07 * Convert.ToDouble(Answer[7]),2));
            Formula.Add("0.07 * " + Answer[7].ToString());

            Answer.Add(Math.Round(0.07 * Convert.ToDouble(Answer[7]),2));
            Formula.Add("0.07 * " + Answer[7].ToString());

            Answer.Add(Math.Round(0.4 * Convert.ToDouble(Answer[3]),2));
            Formula.Add("0.4 * " + Answer[3].ToString());

            Answer.Add(Math.Round(0.6 * Convert.ToDouble(Answer[3]),2));
            Formula.Add("0.6 * " + Answer[3].ToString());

            Answer.Add(Math.Round(0.6 * Convert.ToDouble(Answer[3]),2));
            Formula.Add("0.6 * " + Answer[3].ToString());

            Answer.Add(Math.Round(0.12 * Convert.ToDouble(Answer[7]),2));
            Formula.Add("0.12 * " + Answer[7].ToString());

            Answer.Add(Math.Round(0.12 * Convert.ToDouble(Answer[7]),2));
            Formula.Add("0.12 * " + Answer[7].ToString());

            Answer.Add(Math.Round(0.7 * Convert.ToDouble(Answer[1]),2));
            Formula.Add("0.7 * " + Answer[1].ToString());

            Answer.Add(Math.Round(0.05 * Convert.ToDouble(Answer[7]),2));
            Formula.Add("0.05 * " + Answer[7].ToString());

            Answer.Add(Math.Round(0.05 * Convert.ToDouble(Answer[7]),2));
            Formula.Add("0.05 * " + Answer[7].ToString());

            Answer.Add(Math.Round(0.5 * Convert.ToDouble(Answer[1]),2));
            Formula.Add("0.5 * " + Answer[1].ToString());

            Answer.Add(Math.Round(0.08 * Convert.ToDouble(Answer[7]),2));
            Formula.Add("0.08 * " + Answer[7].ToString());

            Answer.Add(Math.Round(0.08 * Convert.ToDouble(Answer[7]),2));
            Formula.Add("0.08 * " + Answer[7].ToString());

            Answer.Add(Math.Round(0.5 * Convert.ToDouble(Answer[1]),2));
            Formula.Add("0.5 * " + Answer[1].ToString());
        }

        public void PaltoData(TextBox T7, TextBox T9, TextBox T12, TextBox T13, TextBox T14, TextBox T15, TextBox T18, TextBox T19, TextBox T25, TextBox T26, TextBox T29, TextBox T32, TextBox T33, TextBox T34, TextBox T35, TextBox T36, TextBox T38, TextBox T39, TextBox T40, TextBox T44, TextBox T45, TextBox T46, TextBox T47, TextBox T57, TextBox П1191, TextBox П1121, TextBox П1131, TextBox П1141, TextBox П4151, TextBox П3133, TextBox П3335, TextBox П3537, TextBox П3747, TextBox П4757, TextBox П4797, TextBox П3313, TextBox П3515, TextBox П1112, TextBox П12121, TextBox П3132, TextBox П4746, TextBox П4636, TextBox П36372, TextBox П371361, TextBox ПR3616, TextBox П16161, TextBox П411470, TextBox П511570, TextBox П351333ШОР, TextBox П95931, TextBox A17, TextBox A18, TextBox A19, TextBox A21, TextBox A39, TextBox H, TextBox K, TextBox T33331) //Сделать асинхронным
        {
            CalculationIsGet[1] = true;
            AnswerP = new ObservableCollection<double>();
            FormulaP = new ObservableCollection<string>();

            AnswerP.Add(Math.Round(Convert.ToDouble(T40.Text) + (Convert.ToDouble(T7.Text) - Convert.ToDouble(T9.Text)) + Convert.ToDouble(П1191.Text),2));
            FormulaP.Add(T40.Text + " + (" + T7.Text + " - " + T9.Text + ") + " + П1191.Text);

            AnswerP.Add(Math.Round(0.3 * Convert.ToDouble(T40.Text) + Convert.ToDouble(П1121.Text),2));
            FormulaP.Add("0.3 * " + T40.Text + " + " + П1121.Text);

            AnswerP.Add(Math.Round(Convert.ToDouble(T39.Text) + Convert.ToDouble(П1131.Text),2));
            FormulaP.Add(T39.Text + " + " + П1131.Text);

            AnswerP.Add(Math.Round(Convert.ToDouble(T40.Text) + Convert.ToDouble(П1141.Text),2));
            FormulaP.Add(T40.Text + " + " + П1141.Text);

            AnswerP.Add(Math.Round(0.65 * (Convert.ToDouble(T7.Text) - Convert.ToDouble(T12.Text)) + Convert.ToDouble(П4151.Text),2));
            FormulaP.Add("0.65 * (" + T7.Text + " - " + T12.Text + ") + " + П4151.Text);

            AnswerP.Add(Math.Round(0.5 * Convert.ToDouble(T47.Text) + Convert.ToDouble(П4151.Text),2));
            FormulaP.Add("0.5 * " + T47.Text + " + " + П4151.Text);

            AnswerP.Add(Math.Round(Convert.ToDouble(T57.Text) + Convert.ToDouble(П3335.Text),2));
            FormulaP.Add(T57.Text + " + " + П3335.Text);

            AnswerP.Add(Math.Round(0.5 * (Convert.ToDouble(T45.Text) + Convert.ToDouble(T15.Text) - 1.2 - Convert.ToDouble(T14.Text)) + Convert.ToDouble(П3537.Text),2));
            FormulaP.Add("0.5 * (" + T45.Text + " + " + T15.Text + " - 1.2 - " + T14.Text + ") + " + П3537.Text);

            AnswerP.Add(Math.Round(Convert.ToDouble(AnswerP[5]) + Convert.ToDouble(AnswerP[6]) + Convert.ToDouble(AnswerP[7]),2));
            FormulaP.Add(AnswerP[5].ToString() + " + " + AnswerP[6].ToString() + " + " + AnswerP[7].ToString());

            AnswerP.Add(Math.Round(Convert.ToDouble(T40.Text) - Convert.ToDouble(T39.Text) + Convert.ToDouble(П3747.Text),2));
            FormulaP.Add(T40.Text + " - " + T39.Text + " + " + П3747.Text);

            AnswerP.Add(Math.Round(0.65 * (Convert.ToDouble(T7.Text) - Convert.ToDouble(T12.Text)) + Convert.ToDouble(П4757.Text),2));
            FormulaP.Add("0.65 * (" + T7.Text + " - " + T12.Text + ") + " + П4757.Text);

            AnswerP.Add(Math.Round(Convert.ToDouble(T7.Text) - Convert.ToDouble(T9.Text) + Convert.ToDouble(П4797.Text),2));
            FormulaP.Add(T7.Text + " - " + T9.Text + " + " + П4797.Text);

            AnswerP.Add(Math.Round(0.49 * Convert.ToDouble(T38.Text) + Convert.ToDouble(П3313.Text),2));
            FormulaP.Add("0.49 * " + T38.Text + " + " + П3313.Text);

            AnswerP.Add(Math.Round(0.43 * Convert.ToDouble(T38.Text) + Convert.ToDouble(П3313.Text),2));
            FormulaP.Add("0.43 * " + T38.Text + " + " + П3313.Text);

            AnswerP.Add(Math.Round(0.62 * Convert.ToDouble(AnswerP[6]) * Convert.ToDouble(A17.Text),2));
            FormulaP.Add("0.62 * " + AnswerP[6].ToString() + " * " + A17.Text);

            AnswerP.Add(Math.Round(0.38 * Convert.ToDouble(AnswerP[6]) * Convert.ToDouble(A18.Text),2));
            FormulaP.Add("0.38 * " + AnswerP[6].ToString() + " * " + A18.Text);

            AnswerP.Add(Math.Round(0.62 * Convert.ToDouble(AnswerP[6]) * Convert.ToDouble(A19.Text),2));
            FormulaP.Add("0.62 * " + AnswerP[6].ToString() + " * " + A19.Text);

            AnswerP.Add(Math.Round(0.38 * Convert.ToDouble(AnswerP[6]) * Convert.ToDouble(A21.Text),2));
            FormulaP.Add("0.38 * " + AnswerP[6].ToString() + " * " + A21.Text);

            AnswerP.Add(Math.Round(0.18 * Convert.ToDouble(T13.Text) + Convert.ToDouble(П1112.Text),2));
            FormulaP.Add("0.18 * " + T13.Text + " + " + П1112.Text);

            AnswerP.Add(Math.Round(0.25 * Convert.ToDouble(AnswerP[18]),2));
            FormulaP.Add("0.25 * " + AnswerP[18].ToString());

            AnswerP.Add(Math.Round(0.07 * Convert.ToDouble(T13.Text) + Math.Pow(Convert.ToDouble(П12121.Text), 4),2));
            FormulaP.Add("0.07 * " + T13.Text + Math.Round(Math.Pow(Convert.ToDouble(П12121.Text), 4),2).ToString());

            AnswerP.Add(Math.Round(3.5 - 0.08 * Convert.ToDouble(T47.Text),2));
            FormulaP.Add("3.5 - 0.08 * " + T47.Text);

            AnswerP.Add(Math.Round(0.17 * Convert.ToDouble(T47.Text) + Convert.ToDouble(П3132.Text),2));
            FormulaP.Add("0.17 * " + T47.Text + " + " + П3132.Text);

            AnswerP.Add(9);
            FormulaP.Add("9");

            AnswerP.Add(Math.Round(Convert.ToDouble(K.Text) - Math.Pow(Convert.ToDouble(A39.Text), 6),2));//тут К. проверить потом
            FormulaP.Add(" " + K.Text + " - " + Math.Round(Math.Pow(Convert.ToDouble(A39.Text), 6),2).ToString() + " ");

            AnswerP.Add(Math.Round(Convert.ToDouble(K.Text) - Convert.ToDouble(A39.Text),2));
            FormulaP.Add(" " + K.Text + " - " + A39.Text + " ");

            AnswerP.Add(Math.Round(0.5 * Convert.ToDouble(T46.Text) + Convert.ToDouble(П4746.Text),2));
            FormulaP.Add("0.5 * " + T46.Text + " + " + П4746.Text);

            AnswerP.Add(Math.Round(Convert.ToDouble(T36.Text) - Convert.ToDouble(T35.Text) + Convert.ToDouble(П4636.Text),2));
            FormulaP.Add(T36.Text + " - " + T35.Text + " + " + П4636.Text);

            AnswerP.Add(Math.Round(Convert.ToDouble(AnswerP[26]),2));
            FormulaP.Add(AnswerP[26].ToString());

            AnswerP.Add(Math.Round(0.5 * (Convert.ToDouble(T15.Text) - 1.2 - Convert.ToDouble(T14.Text)),2));
            FormulaP.Add("0.5 * (" + T15.Text + " - 1.2 - " + T14.Text + ")");

            AnswerP.Add(Math.Round(0.18 * Convert.ToDouble(T13.Text) + Convert.ToDouble(П371361.Text),2));
            FormulaP.Add("0.18 * " + T13.Text + " + " + П371361.Text);

            AnswerP.Add(Math.Round(Convert.ToDouble(T44.Text) - (Convert.ToDouble(T40.Text) + 0.07 * Convert.ToDouble(T13.Text)) - (Convert.ToDouble(T36.Text) - Convert.ToDouble(T35.Text)) + Convert.ToDouble(ПR3616.Text),2));
            FormulaP.Add(T44.Text + " - (" + T40.Text + " + 0.07 * " + T13.Text + ") - (" + T36.Text + " - " + T35.Text + ") + " + ПR3616.Text);

            AnswerP.Add(Math.Round(0.205 * Convert.ToDouble(T13.Text) + Convert.ToDouble(П16161.Text),2));
            FormulaP.Add("0.205 * " + T13.Text + " + " + П16161.Text);

            AnswerP.Add(Math.Round(0.5 * Convert.ToDouble(T18.Text) + Convert.ToDouble(П411470.Text),2));
            FormulaP.Add("0.5 * " + T18.Text + " + " + П411470.Text);

            AnswerP.Add(Math.Round(0.5 * Convert.ToDouble(T19.Text) + Convert.ToDouble(П411470.Text),2));
            FormulaP.Add("0.5 * " + T19.Text + " + " + П411470.Text);

            //35 ДП
            AnswerP.Add(Math.Round(0.93 * Convert.ToDouble(T38.Text) + (Convert.ToDouble(П3313.Text) + Convert.ToDouble(П3515.Text)) + 0.57 * (Convert.ToDouble(T57.Text) + Convert.ToDouble(П3335.Text)) + 2 * Convert.ToDouble(T33331.Text),2));
            FormulaP.Add("0.93 * " + T38.Text + " + (" + П3313.Text + " + " + П3515.Text + ") + 0.57 * (" + T57.Text + " + " + П3335.Text + ") + 2 * " + T33331.Text);
            //ПОР 36
            AnswerP.Add(Math.Round(Convert.ToDouble(H.Text) * Convert.ToDouble(AnswerP[35]) - 0.1 * 53.87,2));
            FormulaP.Add(H.Text + " * " + AnswerP[35].ToString() + " - 0.1 * 53.87");
            //ДОР 37
            AnswerP.Add(Math.Round((1 + Convert.ToDouble(H.Text)) * Convert.ToDouble(AnswerP[35]) - (1 + 0.1) * 54.2,2));
            FormulaP.Add("(1 + " + H.Text + ") * " + AnswerP[35].ToString() + " - (1 + 0.1) * 54.2");

            AnswerP.Add(Math.Round(Convert.ToDouble(AnswerP[6]),2));
            FormulaP.Add(AnswerP[6].ToString());

            AnswerP.Add(Math.Round(0.62 * Convert.ToDouble(AnswerP[6]) + Convert.ToDouble(A17.Text),2));
            FormulaP.Add("0.62 * " + AnswerP[6].ToString() + " + " + A17.Text);

            AnswerP.Add(Math.Round(0.38 * Convert.ToDouble(AnswerP[6]) - Convert.ToDouble(A21.Text),2));
            FormulaP.Add("0.38 * " + AnswerP[6].ToString() + " - " + A21.Text);

            AnswerP.Add(Math.Round(0.38 * Convert.ToDouble(AnswerP[6]) - Convert.ToDouble(A21.Text),2));
            FormulaP.Add("0.38 * " + AnswerP[6].ToString() + " - " + A21.Text);

            AnswerP.Add(Math.Round(0.38 * Convert.ToDouble(AnswerP[6]) - Convert.ToDouble(A21.Text),2));
            FormulaP.Add("0.38 * " + AnswerP[6].ToString() + " - " + A21.Text);

            AnswerP.Add(Math.Round(Convert.ToDouble(K.Text),2));
            FormulaP.Add(K.Text);
            //44 по счету
            AnswerP.Add(Math.Round(Convert.ToDouble(T57.Text) + 4.5 + Convert.ToDouble(П351333ШОР.Text),2)); //ШОР
            FormulaP.Add(T57.Text + " + 4.5 + " + П351333ШОР.Text);
            //45
            AnswerP.Add(Math.Round(0.885 * Convert.ToDouble(AnswerP[37]) * Math.Sqrt(0.25 - Math.Pow(Convert.ToDouble(AnswerP[44]) / Convert.ToDouble(AnswerP[37]), 2)),2));
            FormulaP.Add("0.885 * " + AnswerP[37].ToString() + " * " + Math.Round(Math.Sqrt(0.25 - Math.Pow(Convert.ToDouble(AnswerP[44]) / Convert.ToDouble(AnswerP[37]), 2)), 2).ToString());//72 ВОР

            AnswerP.Add(Math.Round(0.5 * Convert.ToDouble(T29.Text) + Convert.ToDouble(П95931.Text),2));//90 отрезок
            FormulaP.Add("0.5 * " + T29.Text + " + " + П95931.Text);

            AnswerP.Add(Math.Round(0.5 * Convert.ToDouble(AnswerP[46]),2));
            FormulaP.Add("0.5 * " + AnswerP[46].ToString());
        }

        public void BryukiData(TextBox T1, TextBox T7, TextBox T8, TextBox T9, TextBox T12, TextBox T18, TextBox T19, TextBox T22, TextBox T25, TextBox T26, TextBox T27, TextBox T51, TextBox П5157, TextBox П5158, TextBox П5758, TextBox П7278, TextBox П72741, TextBox П76741, TextBox П7678, TextBox П9298, TextBox П92941, TextBox П96941, TextBox П9698, TextBox П41470, TextBox П47047dt, TextBox A31, TextBox K) //Сделать асинхронным
        {
            CalculationIsGet[2] = true;
            AnswerB = new ObservableCollection<double>();
            FormulaB = new ObservableCollection<string>();

            AnswerB.Add(Math.Round(0.65 * (Convert.ToDouble(T7.Text) - Convert.ToDouble(T12.Text)) - 2.0,2));
            FormulaB.Add("0.65 * (" + T7.Text + " - " + T12.Text + ") - 2.0");

            AnswerB.Add(Math.Round(0.5 * Convert.ToDouble(T19.Text) + Convert.ToDouble(П5157.Text),2));
            FormulaB.Add("0.5 * " + T19.Text + " + " + П5157.Text);

            AnswerB.Add(Math.Round(0.53 * Convert.ToDouble(AnswerB[1]),2));
            FormulaB.Add("0.53 * " + AnswerB[1].ToString());

            AnswerB.Add(Math.Round(0.47 * Convert.ToDouble(AnswerB[1]),2));
            FormulaB.Add("0.47 * " + AnswerB[1].ToString());

            AnswerB.Add(Math.Round(Convert.ToDouble(T26.Text) - 2.0,2));
            FormulaB.Add(T26.Text + " - 2.0");

            AnswerB.Add(Math.Round(Convert.ToDouble(T25.Text) - 2.0,2));
            FormulaB.Add(T25.Text + " - 2.0");

            AnswerB.Add(Math.Round(Convert.ToDouble(T8.Text),2));
            FormulaB.Add(T8.Text);

            AnswerB.Add(Math.Round(Convert.ToDouble(T27.Text) + 1.5,2));
            FormulaB.Add(T27.Text + " + 1.5");

            AnswerB.Add(Math.Round(Convert.ToDouble(T9.Text),2));
            FormulaB.Add(T9.Text);

            AnswerB.Add(Math.Round(0.04 * Convert.ToDouble(T1.Text) - 5.0,2));
            FormulaB.Add("0.04 * " + T1.Text + " - 5.0");

            AnswerB.Add(Math.Round(0.665 * (0.2 * Convert.ToDouble(T19.Text) - 2.0) + Convert.ToDouble(П5158.Text),2));
            FormulaB.Add("0.665 * (0.2 * " + T19.Text + " - 2.0) + " + П5158.Text);

            AnswerB.Add(Math.Round(0.335 * (0.2 * Convert.ToDouble(T19.Text) - 2.0) + Convert.ToDouble(П5758.Text),2));
            FormulaB.Add("0.335 * (0.2 * " + T19.Text + " - 2.0) + " + П5758.Text);

            AnswerB.Add(Math.Round(0.5 * Convert.ToDouble(AnswerB[10]) + Convert.ToDouble(AnswerB[2]),2));//Возможно не 10
            FormulaB.Add("0.5 * " + AnswerB[10].ToString() + " + " + AnswerB[2].ToString());

            AnswerB.Add(Math.Round(0.5 * Convert.ToDouble(AnswerB[3]) + Convert.ToDouble(AnswerB[11]),2));
            FormulaB.Add("0.5 * " + AnswerB[3].ToString() + " + " + AnswerB[11].ToString());

            AnswerB.Add(Math.Round(0.275 * (Convert.ToDouble(T22.Text) + Convert.ToDouble(П7278.Text)),2));
            FormulaB.Add("0.275 * (" + T22.Text + " + " + П7278.Text + ")");

            AnswerB.Add(Math.Round(0.275 * (Convert.ToDouble(T22.Text) + Convert.ToDouble(П72741.Text)),2));
            FormulaB.Add("0.275 * (" + T22.Text + " + " + П72741.Text + ")");

            AnswerB.Add(Math.Round(0.225 * (Convert.ToDouble(T22.Text) + Convert.ToDouble(П76741.Text)),2));
            FormulaB.Add("0.225 * (" + T22.Text + " + " + П76741.Text + ")");

            AnswerB.Add(Math.Round(0.225 * (Convert.ToDouble(T22.Text) + Convert.ToDouble(П7678.Text)),2));
            FormulaB.Add("0.225 * (" + T22.Text + " + " + П7678.Text + ")");

            AnswerB.Add(Math.Round(0.275 * (Convert.ToDouble(T51.Text) + Convert.ToDouble(П9298.Text)),2));
            FormulaB.Add("0.275 * (" + T51.Text + " + " + П9298.Text + ")");

            AnswerB.Add(Math.Round(0.275 * (Convert.ToDouble(T51.Text) + Convert.ToDouble(П92941.Text)),2));
            FormulaB.Add("0.275 * (" + T51.Text + " + " + П92941.Text + ")");

            AnswerB.Add(Math.Round(0.225 * (Convert.ToDouble(T51.Text) + Convert.ToDouble(П96941.Text)),2));
            FormulaB.Add("0.225 * (" + T51.Text + " + " + П96941.Text + ")");

            AnswerB.Add(Math.Round(0.225 * (Convert.ToDouble(T51.Text) + Convert.ToDouble(П9698.Text)),2));
            FormulaB.Add("0.225 * (" + T51.Text + " + " + П9698.Text + ")");
            //22 
            AnswerB.Add(Math.Round(0.5 * Convert.ToDouble(T18.Text) + Convert.ToDouble(П41470.Text),2));
            FormulaB.Add("0.5 * " + T18.Text + " + " + П41470.Text);

            AnswerB.Add(Math.Round(Convert.ToDouble(A31.Text),2));
            FormulaB.Add(A31.Text);

            AnswerB.Add(Math.Round(Convert.ToDouble(K.Text),2));
            FormulaB.Add(K.Text);

            AnswerB.Add(Math.Round(Convert.ToDouble(K.Text),2));
            FormulaB.Add(K.Text);
            //26 Dt
            AnswerB.Add(Math.Round((0.5 * Convert.ToDouble(T19.Text) + Convert.ToDouble(П47047dt.Text)) - (0.5 * Convert.ToDouble(T18.Text) + Convert.ToDouble(П47047dt.Text)),2));
            FormulaB.Add("(0.5 * " + T19.Text + " + " + П47047dt.Text + ") - (0.5 * " + T18.Text + " + " + П47047dt.Text + ")");

            AnswerB.Add(Math.Round(0.2 * Convert.ToDouble(AnswerB[26]),2));
            FormulaB.Add("0.2 * " + AnswerB[26].ToString());

            AnswerB.Add(Math.Round(0.2 * Convert.ToDouble(AnswerB[26]),2));
            FormulaB.Add("0.2 * " + AnswerB[26].ToString());

            AnswerB.Add(Math.Round(0.07 * Convert.ToDouble(AnswerB[26]),2));
            FormulaB.Add("0.07 * " + AnswerB[26].ToString());

            AnswerB.Add(Math.Round(0.3 * Convert.ToDouble(AnswerB[2]),2));
            FormulaB.Add("0.3 * " + AnswerB[2].ToString());

            AnswerB.Add(Math.Round(0.65 * Convert.ToDouble(AnswerB[0]),2));
            FormulaB.Add("0.65 * " + AnswerB[0].ToString());

            AnswerB.Add(Math.Round(0.1 * Convert.ToDouble(AnswerB[26]),2));
            FormulaB.Add("0.1 * " + AnswerB[26].ToString());

            AnswerB.Add(Math.Round(0.1 * Convert.ToDouble(AnswerB[26]),2));
            FormulaB.Add("0.1 * " + AnswerB[26].ToString());

            AnswerB.Add(Math.Round(0.6 * Convert.ToDouble(AnswerB[2]),2));
            FormulaB.Add("0.6 * " + AnswerB[2].ToString());

            AnswerB.Add(Math.Round(0.5 * Convert.ToDouble(AnswerB[0]),2));
            FormulaB.Add("0.5 * " + AnswerB[0].ToString());

            AnswerB.Add(Math.Round(0.1 * Convert.ToDouble(AnswerB[26]),2));
            FormulaB.Add("0.1 * " + AnswerB[26].ToString());

            AnswerB.Add(Math.Round(0.1 * Convert.ToDouble(AnswerB[26]),2));
            FormulaB.Add("0.1 * " + AnswerB[26].ToString());

            AnswerB.Add(Math.Round(0.45 * Convert.ToDouble(AnswerB[0]),2));
            FormulaB.Add("0.45 * " + AnswerB[0].ToString());

            AnswerB.Add(Math.Round(0.065 * Convert.ToDouble(AnswerB[26]),2));
            FormulaB.Add("0.065 * " + AnswerB[26].ToString());
            // 0 - 40
            AnswerB.Add(Math.Round(0.065 * Convert.ToDouble(AnswerB[26]),2));
            FormulaB.Add("0.065 * " + AnswerB[26].ToString());
        }
    }
}
