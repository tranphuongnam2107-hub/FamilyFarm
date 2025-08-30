# FamilyFarm - Backend
Backend for **FamilyFarm** app – an agricultural social networking platform that combines scheduling and problem solving with progress.

# Technologies
- **ASP.NET Core** - Backend framework, we use it to develop RESTful API with ASP.NET Core 8.
- **MongoDB** – NoSQL Database.
- **JWT Authentication - Refresh Token** – Secure login/registration.
- **SignalR** – Real-time (chat, notifications).
- **Firebase Cloud Storage** – Upload photos, videos and files.

# Install dependencies
npm install

## 🔥 Firebase Configuration
In the BusinessLogic layer, there needs to be a JSON file containing the Firebase Service Account information.
Since this file is confidential, **do not push it to the repo**.
### How to create file:
1. Go to [Firebase Console](https://console.firebase.google.com/)
2. Go to **Project Settings** > **Service accounts**
3. Select **Generate new private key**
4. Firebase will download a `.json` file
5. Open the project, access the BusinessLogic layer
6. Create a Firebase folder and paste the Firebase json file here
7. Access the API layer and open the appsetting.json file
8. Check if the Firebase configuration path is correct where the Firebase Json file is saved
9. Access file UploadFileService.cs in BusinessLayer -> Services -> UploadFileService.cs and update config such as name project on your project Firebase.
