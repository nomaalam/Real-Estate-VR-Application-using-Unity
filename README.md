# \# Real-Estate-VR-Application-using-Unity

# 

# This repository contains the implementation of a \*\*Virtual Reality (VR) Real Estate Application\*\* developed as part of a \*\*Virtual Reality course project\*\*.  

# The project addresses the \*visualization gap\* in traditional real estate marketing by enabling \*\*fully immersive, interactive VR property walkthroughs\*\*.

# 

# ---

# 

# \## Project Overview

# 

# Traditional real estate listings rely on 2D photos and floor plans, which fail to convey:

# \- True scale and depth  

# \- Spatial layout  

# \- Lighting and ambiance  

# 

# This VR application allows users to:

# \- Walk through a property in full 3D VR

# \- Interact with objects using physics-based controls

# \- Control lighting dynamically for realistic inspection  

# 

# The project demonstrates how \*\*legacy 3D assets\*\* can be modernized using \*\*Unity + OpenXR + URP + VR Builder\*\*.

# 

# ---

# 

# \## Key Features

# 

# \- \*\*Full VR Walkthrough\*\*

# &nbsp; - Smooth locomotion using XR Interaction Toolkit

# &nbsp; - Collision-based navigation (no walking through walls)

# 

# \- \*\*Physics-Based Object Interaction\*\*

# &nbsp; - Grab, move, and release furniture

# &nbsp; - Realistic gravity and collision behavior

# 

# \- \*\*User-Controlled Dynamic Lighting\*\*

# &nbsp; - Flashlight attached to VR controller

# &nbsp; - Toggle lighting using controller input (via VR Builder no-code logic)

# 

# \- \*\*Cross-Platform VR Compatibility\*\*

# &nbsp; - Built on OpenXR for headset-agnostic support

# 

# 

# \## System Architecture

# 

# The application follows a layered architecture:

# 

# 1\. \*\*Hardware Layer\*\* – PC / VR Headset  

# 2\. \*\*Unity Engine Layer\*\* – Rendering (URP), physics  

# 3\. \*\*XR Interaction Toolkit\*\* – Locomotion \& interaction  

# 4\. \*\*VR Builder Layer\*\* – No-code interaction logic  

# 5\. \*\*Application Layer\*\* – 3D assets \& scene configuration  

# 

# ---

# 

# \## Technology Stack

# 

# | Category | Technology |

# |--------|-----------|

# | Game Engine | Unity 6 (6000.1.14f1) |

# | Rendering | Universal Render Pipeline (URP) |

# | VR SDK | OpenXR + XR Interaction Toolkit |

# | Framework | VR Builder |

# | Testing | XR Device Simulator |

# | Assets | Furnished Cabin (Legacy 3D Asset) |

# 

# ---

# 

# \## Steps to run the project on Unity

# 

# This project is developed using \*\*Unity 6\*\* with \*\*OpenXR-based VR support\*\*.  

# It can be run \*\*with or without a physical VR headset\*\*.

# 

# ---

# 

# \## ✅ Prerequisites

# 

# \### 🔹 Software Requirements

# \- \*\*Unity Hub\*\*

# \- \*\*Unity Editor 6 (6000.1.14f1)\*\* \*(recommended)\*

# \- \*\*Windows OS\*\* \*(recommended)\*

# 

# \### 🔹 Unity Packages

# \- Universal Render Pipeline (URP)

# \- XR Interaction Toolkit

# \- OpenXR Plugin

# \- VR Builder

# \- XR Device Simulator

# 

# > All required packages are already configured in the project.

# 

# ---

# 

# \### Step 1: Clone the Repository

# 

# ```bash

# git clone https://github.com/nomaalam/Real-Estate-VR-Application-using-Unity.git

# ```

# Or download the ZIP and extract it.

# 

# \### Step 2: Open the Project in Unity

# 

# 1\.  Open \*\*Unity Hub\*\*.

# 2\.  Click \*\*Open\*\* → \*\*Add Project from Disk\*\*.

# 3\.  Select the root folder of this repository.

# 4\.  Open the project using \*\*Unity 6\*\*.

# 

# > \*\*Note:\*\* First load may take a few minutes while packages are imported.

# 

# \### Step 3: Verify Project Settings

# 

# \*\*XR Setup\*\*

# \* Go to: `Edit → Project Settings → XR Plug-in Management`

# \* Ensure \*\*OpenXR\*\* is enabled.

# \* Ensure Target platform is \*\*PC, Mac \& Linux Standalone\*\*.

# 

# \*\*Input System\*\*

# \* Go to: `Edit → Project Settings → Player → Active Input Handling`

# \* Set to: \*\*Input System Package (New)\*\* OR \*\*Both\*\*.

# 

# \### Step 4: Run Without a VR Headset (Simulator Mode)

# 

# If you do not have a VR headset, you can still run and test the project using the \*\*XR Device Simulator\*\*.

# 

# 1\.  Open the main scene.

# 2\.  Press \*\*Play ▶️\*\* in Unity.

# 

# 

# If you have a compatible headset (Meta Quest, HTC Vive, etc.):

# 

# 1\.  Connect headset to PC via Link Cable or AirLink.

# 2\.  Ensure \*\*Meta Link\*\* or \*\*SteamVR\*\* is running.

# 3\.  Ensure your headset supports \*\*OpenXR\*\*.

# 4\.  Press \*\*Play ▶️\*\* in Unity.

