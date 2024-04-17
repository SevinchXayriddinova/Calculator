namespace Calculator
{
	public partial class MainPage : ContentPage
	{
		
		public static List<double> MainList = new List<double>();
		public static List<char> OperationsList = new List<char>() { };
		public List<char> opertors = new List<Char>() { '+', '-', '/', '*' };
		public MainPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			try
			{

				var lasts = Editor1.Text[Editor1.Text.Length - 1];
				if (lasts == '+' || lasts == '-' || lasts == '*' || lasts == '/')
				{
					Editor1.Text += Math.E.ToString().Remove(4);
				}
				else
				{
					Editor1.Text = string.Empty; 
					Editor1.Text = Math.E.ToString().Remove(4);
				}
			}
			catch
			{
				Editor1.Text = Math.E.ToString().Remove(4);
			}

        }

		private void BtnP_Clicked(object sender, EventArgs e)
		{
			try
			{

				var lasts = Editor1.Text[Editor1.Text.Length - 1];
				if (lasts == '+' || lasts == '-' || lasts == '*' || lasts == '/')
				{
					Editor1.Text += Math.PI.ToString().Remove(4);
				}
				else
				{
					Editor1.Text = string.Empty;
					Editor1.Text = Math.PI.ToString().Remove(4);
				}
			}
			catch
			{
				Editor1.Text = Math.PI.ToString().Remove(4);
			}
		}

		private void BtnAc_Clicked(object sender, EventArgs e)
		{
			TextTask.Text = string.Empty;
			Editor1.Text = string.Empty;
			MainList.Clear();
			OperationsList.Clear();

		}

		private void BtnDel_Clicked(object sender, EventArgs e)
		{
			try
			{

				var last = Editor1.Text.ElementAt(Editor1.Text.Length - 1);
			
				if (opertors.Any(x => x == last))
				{
					OperationsList.RemoveAt(OperationsList.Count() - 1);
					MainList.Remove(MainList.Count - 1);
				}
				Editor1.Text = Editor1.Text.Remove(Editor1.Text.Length - 1);
			}
			catch
			{
				
			}

		}

		private void Btn7_Clicked(object sender, EventArgs e)
		{
			Editor1.Text +=  '7';

		}

		private void Btn8_Clicked(object sender, EventArgs e)
		{
			Editor1.Text +=  '8';
		}

		private void Btn9_Clicked(object sender, EventArgs e)
		{
			Editor1.Text +=  '9';
		}

		private void BtnMin_Clicked(object sender, EventArgs e)
		{
			var lNumber = "";
			if (opertors.Any(x => x == Editor1.Text.ElementAt(Editor1.Text.Length - 1)))
			{
				OperationsList.RemoveAt(OperationsList.Count()-1);
				Editor1.Text = Editor1.Text.Remove(Editor1.Text.Length-1);
				
			}
			else
			{

				if(OperationsList.Count > 0)
				{
					lNumber = Editor1.Text.Split(OperationsList.Last().ToString()).Last();

				}
				else
				{
					lNumber = Editor1.Text;

				}

				MainList.Add(double.Parse(lNumber));
			}
			OperationsList.Add('-');
			Editor1.Text += '-';

		}

		private void Btn4_Clicked(object sender, EventArgs e)
		{
			Editor1.Text += '4';
		}
			
		private void Btn5_Clicked(object sender, EventArgs e)
		{
			Editor1.Text += '5';
		}

		private void Btn6_Clicked(object sender, EventArgs e)
		{
			Editor1.Text += '6';
		}

		private void BtnSum_Clicked(object sender, EventArgs e)
		{
			var lNumber = "";
			if (opertors.Any(x => x == Editor1.Text.ElementAt(Editor1.Text.Length - 1)))
			{
				OperationsList.RemoveAt(OperationsList.Count() - 1);
				Editor1.Text = Editor1.Text.Remove(Editor1.Text.Length - 1);

			}
			else
			{

				if (OperationsList.Count > 0)
				{
					lNumber = Editor1.Text.Split(OperationsList.Last().ToString()).Last();

				}
				else
				{
					lNumber = Editor1.Text;

				}

				MainList.Add(double.Parse(lNumber));
			}
			OperationsList.Add('+');
			Editor1.Text += '+';
		}

		private void Btn1_Clicked(object sender, EventArgs e)
		{
			Editor1.Text += '1';
		}

		private void Btn2_Clicked(object sender, EventArgs e)
		{
			Editor1.Text += '2';
		}

		private void Btn3_Clicked(object sender, EventArgs e)
		{
			Editor1.Text += '3';
		}

		private void Btn0_Clicked(object sender, EventArgs e)
		{
			Editor1.Text += '0';
		}

		private void BtnPoint_Clicked(object sender, EventArgs e)
		{
			Editor1.Text +=	'.';
		}

		private void BtnDiv_Clicked(object sender, EventArgs e)
		{
			var lNumber = "";
			if (opertors.Any(x => x == Editor1.Text.ElementAt(Editor1.Text.Length - 1)))
			{
				OperationsList.RemoveAt(OperationsList.Count() - 1);
				Editor1.Text = Editor1.Text.Remove(Editor1.Text.Length - 1);

			}
			else
			{

				if (OperationsList.Count > 0)
				{
					lNumber = Editor1.Text.Split(OperationsList.Last().ToString()).Last();

				}
				else
				{
					lNumber = Editor1.Text;

				}

				MainList.Add(double.Parse(lNumber));
			}
			OperationsList.Add('/');
			Editor1.Text += '/';

		}

		private void BtnMul_Clicked(object sender, EventArgs e)
		{
			var lNumber = "";
			if (opertors.Any(x => x == Editor1.Text.ElementAt(Editor1.Text.Length - 1)))
			{
				OperationsList.RemoveAt(OperationsList.Count() - 1);
				Editor1.Text = Editor1.Text.Remove(Editor1.Text.Length - 1);

			}
			else
			{

				if (OperationsList.Count > 0)
				{
					lNumber = Editor1.Text.Split(OperationsList.Last().ToString()).Last();

				}
				else
				{
					lNumber = Editor1.Text;

				}

				MainList.Add(double.Parse(lNumber));
			}
			OperationsList.Add('*');
			Editor1.Text += '*';

		}

		private void BtnCos_Clicked(object sender, EventArgs e)
		{
			if (!opertors.Any(x => x == Editor1.Text.ElementAt(Editor1.Text.Length - 1)) && OperationsList.Count>0)
			{
				var lNumber = Editor1.Text.Split(OperationsList.Last().ToString()).Last();
				MainList.Add(double.Parse(lNumber));
			}
			else
			{
				MainList.Add(double.Parse(Editor1.Text));
			}
			var res = Math.Cos(Calculator.SolveMath(MainList, OperationsList));
			Editor1.Text = res.ToString();
			MainList.Clear();
			OperationsList.Clear();
			TextTask.Text = string.Empty;
		}

		private void BtnSin_Clicked(object sender, EventArgs e)
		{
			if (!opertors.Any(x => x == Editor1.Text.ElementAt(Editor1.Text.Length - 1)) && OperationsList.Count > 0)
			{
				var lNumber = Editor1.Text.Split(OperationsList.Last().ToString()).Last();
				MainList.Add(double.Parse(lNumber));
			}
			else
			{
				MainList.Add(double.Parse(Editor1.Text));
			}

			var res = Math.Sin(Calculator.SolveMath(MainList, OperationsList));
			Editor1.Text= res.ToString();
			MainList.Clear();
			OperationsList.Clear();
			TextTask.Text = string.Empty;

		}


		private void BtnEqual_Clicked(object sender, EventArgs e)
		{
			try
			{
				if (!opertors.Any(x => x == Editor1.Text.ElementAt(Editor1.Text.Length - 1)) && OperationsList.Count > 0)
				{
					var lNumber = Editor1.Text.Split(OperationsList.Last().ToString()).Last();
					MainList.Add(double.Parse(lNumber));
				}
				else
				{
					MainList.Add(double.Parse(Editor1.Text));
				}
				var res =Calculator.SolveMath(MainList, OperationsList);
				MainList.Clear();
				OperationsList.Clear();
				TextTask.Text=string.Empty;
				Editor1.Text = res.ToString();

			}
			catch (Exception ex)
			{
				TextTask.Text = ex.Message;

			}
			
		}

		/*private void OnCounterClicked(object sender, EventArgs e)
		{
			count++;

			if (count == 1)
				CounterBtn.Text = $"Clicked {count} time";
			else
				CounterBtn.Text = $"Clicked {count} times";

			SemanticScreenReader.Announce(CounterBtn.Text);
		}*/
	}

}
