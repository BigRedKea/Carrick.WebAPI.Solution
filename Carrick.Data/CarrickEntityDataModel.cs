namespace Carrick.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Carrick.Data.Model;

    public partial class CarrickEntityDataModel : DbContext
    {
        public CarrickEntityDataModel()
            : base("name=CarrickDatabase")
        {
        }
     
        public virtual DbSet<Badge> Badges { get; set; }
        public virtual DbSet<BadgeRequest> BadgeRequests { get; set; }
        public virtual DbSet<EventLocation> EventLocations { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<OrganisationUnit> OrganisationUnits { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonScoutingEvent> PersonAtEvents { get; set; }
        public virtual DbSet<PersonSignIn> PersonSignIn { get; set; }
        public virtual DbSet<PersonOrganisationUnit> PersonOrganisationUnits { get; set; }
        public virtual DbSet<PersonPerson> PersonPersons { get; set; }
        public virtual DbSet<PersonResidence> PersonResidences { get; set; }
        public virtual DbSet<PersonScoutingRole> PersonScoutingRoles { get; set; }
        public virtual DbSet<Residence> Residences { get; set; }
        public virtual DbSet<ScoutingEvent> ScoutingEvents { get; set; }
        public virtual DbSet<ScoutingRole> ScoutingRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Badge>()
                .Property(e => e.BadgeName)
                .IsUnicode(false);

            modelBuilder.Entity<Badge>()
                .Property(e => e.BadgeLevel)
                .IsUnicode(false);

            modelBuilder.Entity<OrganisationUnit>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.PreferredName)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.MembershipId)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.MedicareNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.NotesForMembership)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.FamilyCode)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PersonScoutingEvent>()
                .Property(e => e.MoneyPaid)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PersonSignIn>()
                .Property(e => e.SignInStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Residence>()
                .Property(e => e.ResidencePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Residence>()
                .Property(e => e.ResidenceAddressLine1)
                .IsUnicode(false);

            modelBuilder.Entity<Residence>()
                .Property(e => e.ResidenceAddressLine2)
                .IsUnicode(false);

            modelBuilder.Entity<Residence>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<Residence>()
                .Property(e => e.PostCode)
                .IsFixedLength();

            modelBuilder.Entity<ScoutingEvent>()
                .Property(e => e.EventName)
                .IsUnicode(false);

            modelBuilder.Entity<ScoutingEvent>()
                .Property(e => e.LinkToMoreInformation)
                .IsUnicode(false);

            modelBuilder.Entity<ScoutingRole>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ScoutingRole>()
                .Property(e => e.ShortText)
                .IsFixedLength();
        }
    }
}
