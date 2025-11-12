# Unity XR Projects: VR & AR
> A repository containing two beginner projects built in Unity to explore Extended Reality (XR).

This repository contains the source code for two separate applications:
1.  **VR Shooting Gallery:** A basic VR game for the Meta Quest 3 where the player shoots cubes and earns points.
2.  **AR Language Flashcards:** An Augmented Reality app for Android that brings a "Hola" flashcard to life with video and audio.

## 📦 Projects Included

### 1. VR Shooting Gallery
A simple, immersive VR game. The player is on a plane with several target cubes. Using the right-hand controller as a "gun," the player can aim and pull the trigger to fire a raycast. When a cube is hit, it's destroyed, and the player's score increases.

* **Platform:** VR (Meta Quest)
* **Scene File:** `MyGame.unity`
* **Core Features:**
    * VR headset and controller tracking (`XR Interaction Toolkit`).
    * Raycast-based "gun" script attached to the right controller.
    * Input handling for the controller trigger (`XRI R Activate`).
    * "Destroyable" tags on targets for hit detection.
    * A simple `GameManager` to track and display the score in a world-space UI.
    * A particle-based "Muzzle Flash" for visual feedback.

### 2. AR Language Flashcards
A practical and educational Augmented Reality tool. When the user points their phone's camera at a specific flashcard (in this case, one with the word "Hola"), the app recognizes the image and overlays a video animation of the word being spoken, along with the corresponding audio.

* **Platform:** AR (Android Phone)
* **Scene File:** `MyImageTrackingScene.unity`
* **Core Features:**
    * Image Tracking (`AR Foundation`).
    * Uses a `Reference Image Library` to store and recognize the "Hola" flashcard.
    * Spawns a prefab (a 2D `Quad` with a `Video Player`) on top of the recognized image.
    * Anchors the video prefab to the card, so it "sticks" to it in 3D space.
    * `Play On Awake` for both video and audio to provide immediate feedback.

## 🛠️ Technology Used

* **Unity Editor (2022.3.x LTS)**
* **C#** (for all game logic and interaction)
* **Unity Packages:**
    * `XR Interaction Toolkit` (for VR)
    * `AR Foundation` (for AR)
    * `ARCore XR Plugin` (for AR)
    * `Oculus XR Plugin` (for VR)
* **Target Platforms:**
    * Android (Meta Quest)
    * Android (Mobile)

---

## ⚙️ How to Run This Project from GitHub

To clone, build, and run these projects, follow these steps.

### Step 1: Software Requirements

Before you begin, make sure you have the following software installed:

1.  **Unity Hub**
2.  **Unity Editor (Version 2022.3.x LTS)**
3.  When installing the editor from Unity Hub, you **must** include the following modules:
    * `Android Build Support`
    * (Inside Android Build Support) `OpenJDK (JDK)`
    * (Inside Android Build Support) `Android SDK & NDK Tools`

### Step 2: Clone & Open the Project

1.  Clone this repository to your local machine using git:
    ```bash
    git clone [URL_TO_YOUR_GITHUB_REPOSITORY]
    ```
2.  Open **Unity Hub**.
3.  Click the **"Open"** button and select the folder you just cloned.
4.  Unity will open the project. This may take several minutes as it imports all assets.

### Step 3: Build the Project (APK)

Because this repository contains two *different* projects, you must build them one at a time with different settings.

1.  In the Unity menu, go to **File > Build Settings**.
2.  Ensure the **Platform** is set to **Android**. If it's not, select `Android` and click **"Switch Platform"**.

#### ⚠️ **Important: Project-Specific Configuration**

You must enable the correct plug-in for the project you want to build.

1.  Go to **Edit > Project Settings...**
2.  Navigate to **XR Plug-in Management** (at the bottom).
3.  Click the **Android Tab** (the 🤖 robot icon).

* **To Build the VR Game:**
    * **CHECK** the box for **"Oculus"**.
    * **UNCHECK** the box for **"ARCore"**.

* **To Build the AR Flashcard App:**
    * **CHECK** the box for **"ARCore"**.
    * **UNCHECK** the box for **"Oculus"**.

#### Final Build Steps

1.  Go back to **File > Build Settings**.
2.  In the **"Scenes In Build"** list, make sure **only** the scene you want to build is checked.
    * For VR: Only check `Scenes/MyGame.unity`
    * For AR: Only check `Scenes/MyImageTrackingScene.unity`
3.  Go to **Player Settings...** > **Other Settings**:
    * Ensure **Scripting Backend** is set to **IL2CPP**.
    * Ensure **Target Architectures** has **ARM64** checked.
    * For the AR project, `Vulkan` may cause issues. If it does, remove it from the **Graphics APIs** list, leaving only `OpenGLES3`.
4.  Go to **Player Settings...** > **Publishing Settings**:
    * You must have a **Keystore** to sign the app. If you don't have one, create one using the **Keystore Manager**.
5.  Close the settings and, in the **Build Settings** window, click **"Build"**. This will create your `.apk` file.

### Step 4: Run the Application

#### ➡️ For the VR Shooting Gallery (Meta Quest)

1.  Enable **Developer Mode** on your Meta Quest headset (this requires the Meta Quest mobile app).
2.  Connect your headset to your PC with a USB-C cable.
3.  Put on the headset and **"Allow USB Debugging"** and **"Allow Data"** from the pop-ups.
4.  Use a tool like **SideQuest** to install the `.apk` file.
5.  Once installed, you can find the game in your **App Library** under the **"Unknown Sources"** filter.

#### ➡️ For the AR Language Flashcard (Android Phone)

1.  Transfer the `.apk` file to your Android phone (e.g., via USB or Google Drive).
2.  On your phone, find the `.apk` file and tap it to install. You may need to grant permissions to **"Install from unknown sources"**.
3.  You will also need the **target image**. Print or display this "Hola" flashcard:
    
4.  Open the app, grant camera permissions, and point your phone at the image to see it come to life.
