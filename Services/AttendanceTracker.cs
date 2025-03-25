namespace EventEase.Services
{
    public class AttendanceTracker
    {
        private readonly List<string> attendees = new List<string>();

        public IReadOnlyList<string> Attendees => attendees;

        public void RegisterAttendance(string attendee)
        {
            attendees.Add(attendee);
        }
    }
}
