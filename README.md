# Sales Data Visualization System

A full-stack application for visualizing sales data, built with a .NET Core Clean Architecture backend and a React frontend.

![Sales Dashboard](https://your-image-url.com)

## Features

- **Clean Architecture**: Follows the principles of Clean Architecture with distinct layers.
- **CQRS Pattern**: Uses MediatR for Command Query Responsibility Segregation.
- **Visualization**: Interactive charts and tables for sales data analysis.
- **Responsive Design**: Mobile-friendly dashboard interface.
- **RESTful API**: Well-structured API endpoints for data access.

## Tech Stack

### Backend
- .NET Core 9.0
- Entity Framework Core
- MediatR for CQRS pattern
- SQL Server database
- Clean Architecture

### Frontend
- React 18
- Recharts for data visualization
- Axios for API communication
- Tailwind CSS for styling

## Project Structure
```
DataVisualization/
├── DataVisualization.Core/          # Domain models and interfaces
├── DataVisualization.Application/    # Business logic, CQRS
├── DataVisualization.Infrastructure/ # Data access, repositories
├── DataVisualization.API/            # API controllers, configuration
└── sales-dashboard/                  # React frontend application
```

## Getting Started

### Prerequisites

- .NET SDK 9.0 or later
- Node.js 16.x or later
- SQL Server (or LocalDB)
- Visual Studio 2022 (optional)

### Backend Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/data-visualization.git
   cd data-visualization
   ```
2. Restore .NET packages:
   ```bash
   dotnet restore
   ```
3. Apply database migrations:
   ```bash
   cd DataVisualization.API
   dotnet ef database update
   ```
4. Run the API:
   ```bash
   dotnet run
   ```
   The API will be available at `https://localhost:0000`

### Frontend Setup

1. Navigate to the React app directory:
   ```bash
   cd sales-dashboard
   ```
2. Install dependencies:
   ```bash
   npm install
   ```
3. Start the development server:
   ```bash
   npm start
   ```
   The application will be available at `http://localhost:3000`

## API Endpoints

| Method | Endpoint            | Description                     |
|--------|---------------------|---------------------------------|
| GET    | /api/SalesData      | Get all sales records          |
| GET    | /api/SalesData/{id} | Get a specific sales record    |
| POST   | /api/SalesData      | Create a new sales record      |

## Data Model

### SalesData
- **Id (int)**: Unique identifier
- **Product (string)**: Product name
- **Region (string)**: Sales region
- **Date (DateTime)**: Date of sale
- **Amount (decimal)**: Sale amount
- **Units (int)**: Number of units sold

## Dashboard Components

- **Sales Summary**: Key metrics including total sales, units, regions, and products.
- **Sales by Product Chart**: Bar chart showing sales amount by product.
- **Sales by Region Chart**: Bar chart showing sales amount by region.
- **Sales Details Table**: Detailed tabular view of all sales records.

## Development

### Adding a New Chart

1. Create a new component in `src/components/`
2. Import necessary chart components from Recharts.
3. Process the data as needed.
4. Add the new component to `App.js`.

### Adding a New API Endpoint

1. Create a new Query/Command in the Application layer.
2. Implement the corresponding Handler.
3. Add a new controller method in the API layer.
4. Add a new service method in the frontend API service.

## Contributing

1. Fork the repository.
2. Create a feature branch:
   ```bash
   git checkout -b feature/amazing-feature
   ```
3. Commit your changes:
   ```bash
   git commit -m 'Add some amazing feature'
   ```
4. Push to the branch:
   ```bash
   git push origin feature/amazing-feature
   ```
5. Open a Pull Request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- Clean Architecture by Robert C. Martin
- MediatR by Jimmy Bogard
- Recharts for the visualization components

