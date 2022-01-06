using System.Collections.Generic;
using System;

namespace Clinic.Models
{
  public class Patient
  {
    public Patient()
    {
      this.JoinEntities = new HashSet<DoctorPatient>();
    }

    public int PatientId { get; set; }
    public string PatientName { get; set; }
    public DateTime Birthdate { get; set; }

    public virtual ICollection<DoctorPatient> JoinEntities { get; }
  }
}