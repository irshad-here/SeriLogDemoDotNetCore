# Serilog Demo using .Net 8

This repository demonstrates how to integrate **Serilog** into an ASP.NET Core application for logging purposes. Serilog is a powerful, flexible, and easy-to-use logging library for .NET applications that supports structured logging.

## Features

- Logs to both the **Console** and a **File**.
- File logs are automatically rotated every hour.
- Limits the size of each log file to 1MB, and rolls over to a new file once the limit is reached.
- Logs various levels of information (e.g., Debug, Information).

Check out output.png image to see the sample output log file with custom log messages.
