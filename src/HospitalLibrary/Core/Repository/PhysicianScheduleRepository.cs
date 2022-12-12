using HospitalLibrary.Core.Model;
using HospitalLibrary.Settings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLibrary.Core.Repository
{
    public class PhysicianScheduleRepository : IPhysicianScheduleRepository
    {
        private readonly HospitalDbContext _context;

        public PhysicianScheduleRepository(HospitalDbContext context)
        {
            _context = context;
        }

        public void Create(PhysicianSchedule physicianSchedule)
        {
            _context.PhysicianSchedules.Add(physicianSchedule);
            _context.SaveChanges();
        }

        public void Delete(PhysicianSchedule physicianSchedule)
        {
            _context.PhysicianSchedules.Remove(physicianSchedule);
            _context.SaveChanges();
        }

        public PhysicianSchedule Get(int doctorId)
        {
            foreach (var physicianSchedule in GetAll().ToList())
            {
                if (physicianSchedule.DoctorId == doctorId)
                {
                    return physicianSchedule;
                }
            }

            return null;
        }

        public IEnumerable<PhysicianSchedule> GetAll()
        {
            return _context.PhysicianSchedules.Include(r => r.Appointments).Include(r => r.Vacations).ToList();
        }

        public List<Appointment> GetAllAppointments(int patientId)
        {
            if (patientId == 0)
            {
                List<Appointment> appointments = new List<Appointment>();
                
                Appointment temp1 = new Appointment(1, DateTime.Now);
                appointments.Add(temp1);
                Appointment temp2 = new Appointment(2, DateTime.Now);
                appointments.Add(temp2);
                Appointment temp3 = new Appointment(3, DateTime.Now);
                appointments.Add(temp3);

                return appointments;
            }

            return _context.Appointments.ToList();
        }

        public PhysicianSchedule GetById(int id)
        {
            return _context.PhysicianSchedules.Find(id);
        }

        public void Update(PhysicianSchedule physicianSchedule)
        {
            _context.Entry(physicianSchedule).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public PhysicianSchedule GetByDoctorId(int id)
        {
            List<PhysicianSchedule> physicianSchedules = GetAll().ToList();
            
            foreach(PhysicianSchedule physicianSchedule in physicianSchedules)
            {
                if(physicianSchedule.DoctorId == id)
                {
                    return physicianSchedule;
                }
            }
            return null;
        }
    }
}
