Folder X is a C# console application built as an experimental project to learn and practice asynchronous programming (async / await) in .NET.

This project focuses on understanding how async tasks behave, how to run multiple operations in parallel, and how to coordinate them cleanly using Task.WhenAll.

🎯 Project Goal

The main goal of Folder X is to:

Learn how async and await work in real scenarios

Experiment with running multiple folder scans concurrently

Understand proper async control flow

Avoid blocking the main thread in a console application

Apply async patterns to file system operations

This is a learning-focused project, not a finished production tool.

🖥️ Application Type

Type: Console Application

Language: C#

Framework: .NET

Focus: Asynchronous programming & task coordination

⚙️ How It Works

The user can select one or more folders

Each selected folder is processed asynchronously

Folder scans run in parallel

The application waits for all active tasks to complete before continuing

Async behavior is handled using:

async / await

Task

Task.WhenAll

🚧 Project Status

This project is experimental and educational.

Code may change as async knowledge improves

Logic is intentionally kept simple and readable

Features are added primarily for learning purposes


🔮 Possible Future Improvements

Cancellation support (CancellationToken)

Progress reporting per folder

Improved file handling (deleting, opening, reading ect)

Support for dynamic folder lists

Logging and performance metrics

📝 Notes

This project is intentionally a console app

No UI frameworks are used

The focus is entirely on async logic and task coordination
