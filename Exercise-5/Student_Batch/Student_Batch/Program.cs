using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Batch
{
	class MainClass
	{
			protected enum GradeLevel { FirstYear = 1, SecondYear, ThirdYear };
			protected class Student
			{
				public string name { get; set; }
				public GradeLevel Year;
				public List<int> ExamScores;
			}

			protected static List<Student> students = new List<Student>
			{
				new Student {name = "Terry", 
					Year = GradeLevel.SecondYear, 
					ExamScores = new List<int>{ 99, 82, 81, 79}} ,
				new Student {name =  "Fadi",
					Year = GradeLevel.ThirdYear,
					ExamScores = new List<int>{ 99, 86, 90, 94}} ,
				new Student {name =  "Hanying", 
					Year = GradeLevel.FirstYear, 
					ExamScores = new List<int>{ 93, 92, 80, 87}} ,
				new Student {name= "Cesar", 
					Year = GradeLevel.ThirdYear,
					ExamScores = new List<int>{ 97, 89, 85, 82}}			
			} ;
			protected static int GetPercentile(Student s)
			{
				double avg = s.ExamScores.Average();
				return avg > 0 ? (int)avg / 10 : 0;
			}

			private static void TotalsByGradeLevel()
			{
				var categories =
					from student in students
						group student by student.Year into studentGroup
						select new { GradeLevel = studentGroup.Key,   
					TotalScore = studentGroup.Sum(s => s.ExamScores.Sum()) };
				Console.WriteLine("\t\tYEAR \t\t TOTAL SCORE");
				Console.WriteLine("\t\t---- \t\t -----------");
				foreach (var cat in categories)
				{
					Console.WriteLine("\tKey = {0} \t TOTAL= {1}", cat.GradeLevel, cat.TotalScore);
				}
			}

			public static void Main (string[] args)
			{

				TotalsByGradeLevel ();
			}
		}
	}

