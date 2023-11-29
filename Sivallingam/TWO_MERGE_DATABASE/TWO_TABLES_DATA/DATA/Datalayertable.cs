using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using TWO_TABLE_DTO.VIEWMODEL;
using TWO_TABLES_DATA.Interface;
using TWO_TABLES_ENTITY;
using TWO_TABLES_ENTITY.DbModel;

namespace TWO_TABLES_DATA.DATA
{
    public class Datalayertable : Idatalayer
    {
        private readonly TwotablesDbContext _twotablesDbContext;
        public Datalayertable(TwotablesDbContext twotablesDbContext)
        {
            _twotablesDbContext = twotablesDbContext;
        }
        public Task<object> POST(VIEWDETAILS details)
        {
            using (var transaction = _twotablesDbContext.Database.BeginTransaction())
            {
                try
                {
                    var personal = new KAPILAN_DETAILS()
                    {
                        KAPILAN_ID = details.KAPILAN_ID,
                        KAPILAN_NAME = details.KAPILAN_NAME,
                        KAPILAN_DEPARTMENT = details.KAPILAN_DEPARTMENT,
                        KAPILAN_CITY = details.KAPILAN_CITY
                    };
                    _twotablesDbContext.KAPILAN_DETAILS.Add(personal);
                    _twotablesDbContext.SaveChanges();
                    var emp = new SIVA_DETAILS()
                    {
                        SIVA_ID = details.SIVA_ID,
                        SIVA_AGE = details.SIVA_AGE,
                        SIVA_GENDER = details.SIVA_GENDER,
                        KAPILAN_ID = personal.KAPILAN_ID

                    };
                    _twotablesDbContext.SIV_DETAILS.Add(emp);
                    _twotablesDbContext.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
            }
            return null;
        }
        public List<VIEWDETAILS> GET()
        {
            var result = (from ans in _twotablesDbContext.KAPILAN_DETAILS
                          join anss in _twotablesDbContext.SIV_DETAILS on
                          ans.KAPILAN_ID equals anss.KAPILAN_ID
                          select new VIEWDETAILS
                          {
                              KAPILAN_ID = ans.KAPILAN_ID,
                              KAPILAN_NAME = ans.KAPILAN_NAME,
                              KAPILAN_CITY = ans.KAPILAN_CITY,
                              KAPILAN_DEPARTMENT =ans.KAPILAN_DEPARTMENT,
                              SIVA_AGE =anss.SIVA_AGE,
                              SIVA_GENDER =anss.SIVA_GENDER,
                              SIVA_ID =anss.SIVA_ID
                          }).ToList();


                return result;

        }
        public List<VIEWDETAILS> PUT(VIEWDETAILS details) 
        {
            using (var transaction = _twotablesDbContext.Database.BeginTransaction())
            {
                try
                {
                    var personal = _twotablesDbContext.KAPILAN_DETAILS.Find(details.KAPILAN_ID);
                    if (personal != null)
                    {
                        personal.KAPILAN_NAME = details.KAPILAN_NAME;
                       personal.KAPILAN_DEPARTMENT = details.KAPILAN_DEPARTMENT;
                       personal. KAPILAN_CITY = details.KAPILAN_CITY;
                        _twotablesDbContext.SaveChanges();
                    }
                    var emp = _twotablesDbContext.SIV_DETAILS.Find(details.SIVA_ID);
                    if(emp != null) 
                    {
                        emp.SIVA_AGE = details.SIVA_AGE;
                        emp.SIVA_GENDER = details.SIVA_GENDER;
                    }
                
                    _twotablesDbContext.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
            }
            return null;
        }
        public List<VIEWDETAILS> DELETE(VIEWDETAILS details)
        {
            using (var transaction = _twotablesDbContext.Database.BeginTransaction())
            {
                try
                {
                    var personal = _twotablesDbContext.SIV_DETAILS.Find(details.SIVA_ID);
                    if (personal != null)
                    {
                      _twotablesDbContext.Remove(personal);
                        _twotablesDbContext.SaveChanges();
                    }
                    var emp = _twotablesDbContext.KAPILAN_DETAILS.Find(details.KAPILAN_ID);
                    if (emp != null)
                    {
                        _twotablesDbContext.Remove(emp);
                        _twotablesDbContext.SaveChanges();
                    }

                    _twotablesDbContext.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
            }
            return null;
        }
    }
}