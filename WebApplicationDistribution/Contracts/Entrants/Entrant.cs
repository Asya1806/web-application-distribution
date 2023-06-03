using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationDistribution.Contracts.Entrants;

public class Entrant
{
    [Key]
    public int Entrant_Id { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    public string LastName { get; set; }
    
    [Column(TypeName = "nvarchar(50)")]
    public string FirstName { get; set; }
    
    [Column(TypeName = "nvarchar(50)")]
    public string? MiddleName { get; set; }
    
    //пол
    public int Gender_Id { get; set; }
   
    // заявление на платное/бюджет
    public int ApplicationForPaid_Id { get; set; }
                 
    public int TestMath { get; set; }
    
    public int TestPhys { get; set; }
    
    public int TestLang { get; set; }
    
    public int MiddleMark { get; set; }

    public int SumOfPoints { get; set; }
    
    public int MarkMath { get; set; }
        
    public int MarkPhys { get; set; }
    
    // конкурс 
    public int TypeOfСontest_Id { get; set; }
    
    public int Specialty1_Id { get; set; } 
    
    public int Specialty2_Id { get; set; }
    
    public int Specialty3_Id { get; set; }
    
    public int Specialty4_Id { get; set; }
    
    public int Specialty5_Id { get; set; }
    
    public int Specialty6_Id { get; set; }

    // льготы
    public int Benefits_Id { get; set; }
    
    // язык в университете
    public int LangInUniver_Id { get; set; }

    // участвовал в конкурсе 100 идей для Беларуси (да/нет)
    public int _100IdeasForBelarus_Id { get; set; }
    
    // является волонтер (да/нет)
    public int Volunteer_Id { get; set; }

    // является БРСМ (да/нет)
    public int BRYU_Id { get; set; }

    // «Медаль «ДСО(Добровольное спортивное общество) Труд. За высокое спортивное мастерство»»(да/нет)
    public int MedalDSO_Id { get; set; }
    
    //Дополнительное обучение(сколько)
    public int AdditionalTraining { get; set; }
    
    // Населенный пункт
    public int Locality_Id { get; set; }
    
    public int PassportSeries_Id { get; set; }
    
    [Column(TypeName = "nvarchar(50)")]
    public string PassportNumber { get; set; }

    [Column(TypeName = "nvarchar(50)")]

    public string Phone { get; set; }
    
    public int CommissionDecision_Id { get; set; }
}
