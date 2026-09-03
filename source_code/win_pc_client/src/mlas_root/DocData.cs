using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

public class DocData
{
	public class SubjectData
	{
		public class QuestionData
		{
			public enum Type
			{
				A_Question,
				B_subtext,
				C_answer1,
				D_answer2,
				E_answer3,
				F_answer4,
				G_answer5,
				H_correct,
				I_exp
			}

			public string A_question;

			public string B_subtext;

			public string C_answer1;

			public string D_answer2;

			public string E_answer3;

			public string F_answer4;

			public string G_answer5;

			public int H_correct;

			public string I_exp;

			public QuestionData()
			{
			}

			public QuestionData(string question, string subtext, string answer1, string answer2, string answer3, string answer4, string answer5, string correct, string exp)
			{
				A_question = question;
				B_subtext = subtext;
				C_answer1 = answer1;
				D_answer2 = answer2;
				E_answer3 = answer3;
				F_answer4 = answer4;
				G_answer5 = answer5;
				H_correct = checked((int)Math.Round(Conversion.Val(correct)));
				I_exp = exp;
			}
		}

		private object _subjectName;

		private List<QuestionData> Questions;

		public SubjectData(string subjectName)
		{
			Questions = new List<QuestionData>();
			_subjectName = subjectName;
		}

		public void Add()
		{
			Questions.Add(new QuestionData("", "", "", "", "", "", "", "", ""));
		}

		public bool Add(string arg)
		{
			string[] array = arg.Replace("null", "").Split(new string[2] { "\r\n", "\n" }, StringSplitOptions.None);
			if (array.Length == 9)
			{
				Questions.Add(new QuestionData(array[0], array[1], array[2], array[3], array[4], array[5], array[6], array[7], array[8]));
				return true;
			}
			return false;
		}

		public object Add(string question, string subtext, string answer1, string answer2, string answer3, string answer4, string answer5, string correct, string exp)
		{
			try
			{
				Questions.Add(new QuestionData(question, subtext, answer1, answer2, answer3, answer4, answer5, correct, exp));
				return true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				object result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public object RemoveAt(int index)
		{
			try
			{
				Questions.RemoveAt(index);
				return true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				object result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public bool setName(string name)
		{
			_subjectName = name;
			return true;
		}

		public string getName()
		{
			return Conversions.ToString(_subjectName);
		}

		public int Count()
		{
			return Questions.Count;
		}

		public bool setQuestion(int index, QuestionData.Type type, string data)
		{
			QuestionData questionData = Questions[index];
			switch (type)
			{
			case QuestionData.Type.A_Question:
				questionData.A_question = data;
				return true;
			case QuestionData.Type.B_subtext:
				questionData.B_subtext = data;
				return true;
			case QuestionData.Type.C_answer1:
				questionData.C_answer1 = data;
				return true;
			case QuestionData.Type.D_answer2:
				questionData.D_answer2 = data;
				return true;
			case QuestionData.Type.E_answer3:
				questionData.E_answer3 = data;
				return true;
			case QuestionData.Type.F_answer4:
				questionData.F_answer4 = data;
				return true;
			case QuestionData.Type.G_answer5:
				questionData.G_answer5 = data;
				return true;
			case QuestionData.Type.H_correct:
				questionData.H_correct = Conversions.ToInteger(data);
				return true;
			case QuestionData.Type.I_exp:
				questionData.I_exp = data;
				return true;
			default:
				return false;
			}
		}

		public object setQuestion(int index, string[] args)
		{
			QuestionData questionData = Questions[index];
			try
			{
				questionData.A_question = args[0];
				questionData.B_subtext = args[1];
				questionData.C_answer1 = args[2];
				questionData.D_answer2 = args[3];
				questionData.E_answer3 = args[4];
				questionData.F_answer4 = args[5];
				questionData.G_answer5 = args[6];
				questionData.H_correct = Conversions.ToInteger(args[7]);
				questionData.I_exp = args[8];
				return true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				object result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public object setQuestion(int index, QuestionData q)
		{
			QuestionData questionData = Questions[index];
			try
			{
				questionData.A_question = q.A_question;
				questionData.B_subtext = q.B_subtext;
				questionData.C_answer1 = q.C_answer1;
				questionData.D_answer2 = q.D_answer2;
				questionData.E_answer3 = q.E_answer3;
				questionData.F_answer4 = q.F_answer4;
				questionData.G_answer5 = q.G_answer5;
				questionData.H_correct = q.H_correct;
				questionData.I_exp = q.I_exp;
				return true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				object result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public QuestionData getQuestion(int index)
		{
			return Questions[index];
		}

		public QuestionData Clone(int index)
		{
			return new QuestionData
			{
				A_question = Questions[index].A_question,
				B_subtext = Questions[index].B_subtext,
				C_answer1 = Questions[index].C_answer1,
				D_answer2 = Questions[index].D_answer2,
				E_answer3 = Questions[index].E_answer3,
				F_answer4 = Questions[index].F_answer4,
				G_answer5 = Questions[index].G_answer5,
				H_correct = Questions[index].H_correct,
				I_exp = Questions[index].I_exp
			};
		}
	}

	private string _index;

	private string _name;

	private string _group;

	private bool _silgi;

	private List<SubjectData> _subjectData;

	public string Group
	{
		get
		{
			return _group;
		}
		set
		{
			_group = value;
		}
	}

	public string Name
	{
		get
		{
			return _name;
		}
		set
		{
			_name = value;
		}
	}

	public bool Silgi
	{
		get
		{
			return _silgi;
		}
		set
		{
			_silgi = value;
		}
	}

	public int Index
	{
		get
		{
			return checked((int)Math.Round(Conversion.Val(_index)));
		}
		set
		{
			_index = Conversions.ToString(value);
		}
	}

	public DocData(string index, string group, string name, string subjectName, int silgi)
	{
		_subjectData = new List<SubjectData>();
		_index = index;
		_group = group;
		_name = name;
		_silgi = silgi != 0;
		string[] array = subjectName.Split(new string[1] { "/" }, StringSplitOptions.None);
		foreach (string subjectName2 in array)
		{
			_subjectData.Add(new SubjectData(subjectName2));
		}
	}

	public bool Available()
	{
		checked
		{
			if (_subjectData.Count > 0)
			{
				int num = _subjectData.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (_subjectData[i].Count() > 0)
					{
						return true;
					}
				}
				return false;
			}
			return false;
		}
	}

	public int Count()
	{
		return _subjectData.Count;
	}

	public int QuestionCount()
	{
		int num = 0;
		foreach (SubjectData subjectDatum in _subjectData)
		{
			num = checked(num + subjectDatum.Count());
		}
		return num;
	}

	public bool AddSubject(string name)
	{
		try
		{
			_subjectData.Add(new SubjectData(name));
			return true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public bool setSubjectName(int index, string name)
	{
		try
		{
			return _subjectData[index].setName(name);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public object RemoveAt(int index)
	{
		try
		{
			_subjectData.RemoveAt(index);
			return true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string getSubjectName(int index)
	{
		return _subjectData[index].getName();
	}

	public List<SubjectData> SubjectItems()
	{
		return _subjectData;
	}

	public SubjectData SubjectItems(int index)
	{
		return _subjectData[index];
	}

	public void Clear(string[] subjectNames)
	{
		_subjectData = new List<SubjectData>();
		foreach (string subjectName in subjectNames)
		{
			_subjectData.Add(new SubjectData(subjectName));
		}
	}
}
