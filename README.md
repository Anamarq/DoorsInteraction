# VR Doors Interaction (Unity XR)

Reusable **VR door interaction** built with **Unity XR Interaction Toolkit**.  
This package provides ready-to-use prefabs and scripts to add realistic door interactions using **XR Grab Interactable** and **physics joints**, designed to be easily reusable across projects.

---

## Features

- Door interaction using Hinge Joint + XR Grab Interactable   
- Natural grab-based VR interaction  
- Open / close sound feedback  
- Interaction logic separated from visual models  
- Sample scene for testing and learning  
- Installable via Unity Package Manager (Git URL)

---

## Installation

### Install via Unity Package Manager (Git URL)

1. Open **Unity**
2. Go to **Window → Package Manager**
3. Click the **+** button
4. Select **Add package from git URL…**
5. Paste: [https://github.com/anamarq/DoorsInteraction.git?path=com.anamarq.vr.doors](https://github.com/anamarq/DoorsInteraction.git?path=com.anamarq.vr.doors)

Unity will automatically install all required dependencies.

---

## Requirements

### Unity Version
- Unity **6000.3.2** or newer (recommended)

### Unity Packages (installed automatically)
- **XR Interaction Toolkit** (>= 3.3.1)

### Project Settings (manual setup required)

This package requires **XR Plug-in Management** with **OpenXR** enabled.

1. Open **Edit → Project Settings**
2. Go to **XR Plug-in Management**
3. Install it if not already installed
4. Enable **OpenXR**
5. Enable the interaction profile for your device  
   (e.g. Meta Quest / Oculus Touch Controller Profile)

---

## XR Interaction Toolkit Starter Assets (Important)

The **sample scene** included in this package uses the  
**XR Interaction Toolkit Starter Assets**.

These assets are **not redistributed** with this package and must be imported manually.

### How to import Starter Assets

1. Open **Window → Package Manager**
2. Select **XR Interaction Toolkit**
3. Click **Import Samples**
4. Import **Starter Assets**

> ⚠️ The sample scene will not work correctly until the Starter Assets are imported.

---

## Sample Scene

After installing the package:

1. Open **Package Manager**
2. Select this package
3. Click **Import Samples**
4. Open the test scene included in the samples

The sample scene demonstrates:
- A basic XR setup with teleport
- A test furniture model
- Working door interaction
- Correct grab points and sound feedback

---

## Usage Instructions

### Door Setup

1. Place your **door model** in the scene
2. Drag the **Door Interaction Prefab** into the scene
3. Align the prefab position and rotation with the door model
4. Adjust the **collider size and position** (do NOT scale the transform)
5. Move the **handle collider** to match the door handle position
6. Assign the door model to the **Sync Transform** script
7. Assign open/close sounds in the **Door Sound Controller** script
8. Adapt the angle of the **hinge joint** for the door to work correctly


The interaction logic is fully separated from the visual models, allowing reuse with any asset.

---

## Project Structure

com.anamarq.vr.doors/\
├─ Runtime/\
│ ├─ Scripts/\
│ ├─ Prefabs/\
│ └─ Audio/\
├─ Samples~/\
│ └─ TestScene/\
│ ├─ Scenes/\
│ └─ Models/\
├─ Documentation~\
├─ package.json\
└─ README.md

---

## License

This project is licensed under the **MIT License**.  
See the [LICENSE](LICENSE) file for details.

---

## Third-Party Notices

This project depends on the following Unity packages:

- **Unity XR Interaction Toolkit**  
  Copyright © Unity Technologies  
  Licensed under the Unity Companion License

- **XR Interaction Toolkit Starter Assets**  
  Copyright © Unity Technologies  
  Licensed under the Unity Companion License  

These assets are **not redistributed** with this package and must be installed separately.

---

## Portfolio Note

This package is part of my personal portfolio and focuses on:
- VR interaction design
- Reusable systems
- Clean architecture
- Proper Unity package distribution
- Documentation and developer experience

Feedback is welcome.

