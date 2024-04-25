# TCP/IP Message Communication Application
I've developed a desktop application for TCP/IP message communication. This application allows users to send and receive shared messages using the TCP/IP protocol. The application is built using C# Windows Forms.

## Features of the Application:

### Server-Client Option: 
The application can work as either a server or a client based on user preference.

### Message Composition: 
Users can enter the content of each defined message via the user interface and send it to the connected party.

### Message Logging: 
All incoming and outgoing messages are logged on the user interface with timestamps and message names. Messages are tagged with "Transmit" if sent and "Receive" if received.

### Message Display: 
Users can view the content of any selected message from the incoming and outgoing message list.

### Automated Responses: 
When the application receives Message 1, it automatically sends Message 2 as a response, and vice versa.

### Error Handling: 
If the application receives an undefined message, it alerts the user that the message is not defined.
Scheduled Message Sending: Users can schedule the sending of defined messages at specified intervals. For example, Message 1 can be sent every 100 ms and Message 2 every 500 ms.

## Defined Messages

The details of the defined messages are as follows:

### Message 1

| Parameters          | Type    | Length  |
|---------------------|---------|---------|
| Message ID          | Int     | 4 byte  |
| Reference Number    | Int     | 4 byte  |
| Name                | String  | 25 char |
| Unit Number         | Uint32  | 4 byte  |
| Surname             | String  | 25 char |
| Rank                | Short   | 2 byte  |

### Message 2

| Parameters               | Type    | Length  |
|--------------------------|---------|---------|
| Message ID               | Int     | 4 byte  |
| Reference Number         | Int     | 4 byte  |
| Location Validation      | String  | 25 char |
| Latitude                 | Uint32  | 4 byte  |
| Longitude                | String  | 25 char |
| Altitude                 | Short   | 2 byte  |



