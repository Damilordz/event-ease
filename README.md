# EventEase

EventEase is a web application designed for seamless corporate and social event management. Users can browse events, view detailed information, register for events, and manage attendance—all in one intuitive interface. Built using Blazor WebAssembly, the app is optimized for performance and user-friendly interaction.

## Features
- **Event Browsing:** Users can explore events with details such as name, date, and location.
- **Routing:** Navigate smoothly between event list, details, and registration pages.
- **Registration Form:** Secure user registration with built-in validation for input fields (e.g., name and email).
- **State Management:** Tracks user sessions to manage registrations.
- **Attendance Tracking:** Keeps a record of event participants for better organization.
- **Performance Optimization:** Efficient rendering for large event lists using Blazor’s `Virtualize` component.
- **Responsive Interface:** Styled forms and navigation provide a clean and accessible user experience.

## Getting Started
### Prerequisites
- .NET SDK
- A modern web browser

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/Damilordz/event-ease.git
   cd event-ease
   ```
2. Build and run the app:
   ```bash
   dotnet build
   dotnet run
   ```
3. Access the app in your browser at `http://localhost:5033`.

## How Copilot Assisted
- **Component Creation:** Helped generate foundational components like the Event Card with fields and data binding.
- **Routing Implementation:** Provided guidance on setting up routing paths and debugged issues with invalid paths.
- **Optimization:** Suggested using Blazor’s `Virtualize` component to handle large datasets efficiently.
- **Advanced Features:** Assisted in implementing features like the Registration Form with validation and Attendance Tracker.
- **Styling:** Provided CSS suggestions to enhance the user interface.

## Technologies Used
- **Framework:** Blazor WebAssembly
- **Language:** C#
- **Styling:** CSS
- **Version Control:** Git