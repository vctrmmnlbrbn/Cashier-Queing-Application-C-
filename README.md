## 📄 README – Basic Queuing Cashier
## 📌 Overview

This project is a Basic Queuing Cashier System built using C# Windows Forms.
It simulates a simple queueing system where a student gets a queue number, and the cashier processes them in order.

The project consists of:

Form1 (QueuingForm) → Generates queue numbers for students.

CashierWindowQueueForm → Displays the queue, allows refreshing, moving to the next number, and (optionally) auto-refreshing with a timer.

CashierClass → Handles the queue logic using a Queue<T> collection.

## 🎯 Objectives

Use simple and generic collections (Queue) in a program.

Manipulate collections using enqueue and dequeue methods.

Create and use multiple Windows Forms.

## 🖥️ Software Requirements

Windows OS

Visual Studio 2015 or higher

.NET Framework (Windows Forms)

## ⚙️ Features
# ✅ Form1 (QueuingForm)

btnCashier → Generates a new queue number (format: P - 10001, P - 10002, etc.).

lblQueue → Displays the latest generated number.

Stores the generated numbers into the CashierQueue.

# ✅ CashierWindowQueueForm

btnRefresh → Manually refreshes the list to display the queue.

btnNext → Moves to the next number (removes from queue).

listCashierQueue → Displays all current queue numbers.

Challenge: Uses a Timer to automatically refresh the list every second.

## 🏗️ How It Works

Queueing (Form1)

When the Cashier button is clicked, a new number is generated.

The number is displayed in lblQueue and added to the queue.

Cashier Window (CashierWindowQueueForm)

The queue is shown in listCashierQueue.

The cashier can refresh the list or press Next to serve the next student.

With the challenge exercise, the queue automatically refreshes every second.

Both Forms Running Together

Program.cs is set so that both Form1 and CashierWindowQueueForm open when the program starts.

## ▶️ Running the Program

Open the solution (.sln) in Visual Studio.

Set Form1 as the startup form.

Run the program (F5).

Both Form1 (student queueing) and CashierWindowQueueForm (cashier view) will appear.

Try generating queue numbers on Form1 → they will show up in the cashier window.

## 📂 File Structure
BasicQueuingCashier/
│
├── CashierClass.cs                # Handles queue logic
├── Form1.cs (QueuingForm)         # Student queueing window
├── CashierWindowQueueForm.cs      # Cashier window
├── Program.cs                     # Entry point, runs both forms
└── README.md                      # Project documentation

## 📝 Notes

Default queue number starts at P - 10001.

Queue automatically increments with each new student.

Closing Form1 will also close the whole application.
