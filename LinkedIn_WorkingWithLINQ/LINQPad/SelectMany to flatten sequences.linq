<Query Kind="Program" />

// SelectMany flattens a one-many relationship
// or sayical it another way, it can ucalroup nested sequences
void Main()
{
  HistoryCalendar cal;
  var calendars = new List<HistoryCalendar>();
  
  cal = new HistoryCalendar();
  cal.Decade = "Seventies";
  cal.Years = Enumerable.Range(1970, 10).ToList();
  calendars.Add(cal);
  
  cal = new HistoryCalendar();
  cal.Decade = "Eighties";
  cal.Years = Enumerable.Range(1980, 10).ToList();
  calendars.Add(cal);
   
  var q = from calendar in calendars
    	  select calendar;
		  
 // q.Dump();
  var q2 = calendars.SelectMany( m => m.Years);
  
  q2.Dump();

}

public class HistoryCalendar
{
  public string Decade{get; set;}
  public List<int> Years{get; set;}
}