# 🍅 Detection and Management of Vegetation with Anomalies – Multi-Agent System (Traffic Jam)

## 📘 Project Overview
This project develops a **Multi-Agent System (MAS)** for the **detection and management of anomalies in tomato crops** within a **simulated greenhouse** located in Jalisco, Mexico.

The goal is to create a **digital environment** where autonomous agents collaborate to:
- Detect early signs of anomalies such as diseases, nutrient deficiencies, or pest infestations.  
- Analyze and classify these anomalies to determine severity.  
- Execute corrective actions such as treatment, pruning, or isolation.  

The simulation models **autonomy**, **coordination**, and **collaborative problem solving** among agents to enhance crop productivity and resource efficiency.

---

## 👥 Team Members

| Name | Role | Strengths | Areas of Opportunity |
|------|------|------------|----------------------|
| Joaquin Hiroki | Project Leader / MAS Architect | Coordination, system modeling, and agent interaction logic | Improve task delegation |
| Fernanda Jimenez | Developer / Environment Modeler | Implementation of grid environment and agent behaviors | Needs to strengthen documentation |
| Juan Pablo Buenrostro | Research & Data Analyst | Crop anomaly research, parameter calibration | Improve confidence using simulation libraries |
| Joaquin Hiroki | Testing & QA | Scenario testing, consistency checks | Enhance GitHub usage and commit discipline |

### Team Expectations
- Build a working MAS simulation for anomaly detection and management in tomato crops.  
- Integrate concepts of **reactive, deliberative, and hybrid agents**.  
- Ensure transparent communication and consistent documentation.

### Commitments
- Weekly updates via GitHub and group meetings.  
- Shared responsibility for report and code quality.  
- Collaborative debugging and peer review.

---

## 🧭 Context

Tomato (*Solanum lycopersicum*) is one of Mexico’s most important crops, representing a high export value and constant demand.  
However, between **20–40% of total yield** is lost annually due to **diseases, pests, or physiological stress**.  
In Jalisco’s greenhouses, early detection of anomalies is crucial since **delays** in management can quickly propagate diseases and reduce market quality.

This MAS aims to provide an **autonomous decision-support system** that enhances monitoring, reduces losses, and improves sustainable production.

---

## 🎯 Challenge Objective
Design and simulate a **Multi-Agent System (MAS)** capable of **detecting and managing vegetation anomalies** in tomato plants within a digital greenhouse.

---

## 🍅 Selected Crop: **Tomato (Jitomate)**

### Common Detectable Problems

| Problem | Visible Symptom | Detection Method |
|----------|------------------|------------------|
| **Tomato Brown Rugose Fruit Virus (ToBRFV)** | Mosaic patterns, leaf deformation, brown spots on fruit | Color segmentation and texture pattern recognition |
| **Nutrient Deficiency (Nitrogen)** | Yellowing of lower leaves, growth reduction | NDVI index and RGB color deviation |
| **Powdery Mildew** | White powdery patches on leaves and stems | Light reflectance and texture variation detection |

---

## 🧩 Agents Definition

| Agent | Architecture Type | Description | Role |
|--------|--------------------|--------------|------|
| **DetectionAgent (Drone/Robot)** | Reactive | Moves through the grid scanning tomato plants for visual or thermal anomalies. | Detect visible or spectral irregularities. |
| **AnalysisAgent** | Deliberative | Processes the data collected by DetectionAgents, validates symptoms, and classifies the anomaly. | Confirms type and severity of detected problems. |
| **DecisionAgent** | **Hybrid** | Combines deliberative reasoning with reactive response. Decides which management action to execute. | Assign tasks and define resource allocation. |
| **ActionAgent** | Reactive | Executes the selected action (e.g., spray pesticide, prune plant, isolate zone). | Carry out corrective operations. |

---

## 🌿 Digital Representation
Chosen option: **Digital Environment → Simulated Greenhouse**

### Representation Model
- The greenhouse is represented as a **2D grid graph**, where each node corresponds to a **tomato plant cluster**.  
- Each node has states: *Healthy*, *Anomalous*, or *Treated*.  
- Agents navigate through graph edges using efficient pathfinding.

### Technologies / Policy
- **Simulation Framework:** Python (Mesa / NetLogo)  
- **Navigation:** Graph-based model with **Shortest Path (Dijkstra)** and **Minimum Spanning Tree** for coverage.  
- **Decision Policy:** Distributed coordination using **message passing** (request, query, inform).  

---

## 🚜 Greenhouse Navigation

| Concept | Description |
|----------|-------------|
| **Structure** | The greenhouse is modeled as a 10×10 grid with tomato clusters in each cell. |
| **Agent Movement** | Agents move between adjacent cells following optimized graph paths. |
| **Coverage Strategy** | Minimum spanning tree for exploration, shortest path for targeted response. |
| **Traffic Jam Simulation** | When two robots occupy the same path, a negotiation protocol triggers rerouting. |

---

## 🤖 Collaboration Between Agents

### Zone Division
- The greenhouse is divided into four main zones (north, south, east, west).  
- Each DetectionAgent operates in one zone.  
- DecisionAgent reallocates tasks dynamically to balance the workload.

### Task Sharing
- DetectionAgents share data through local message exchange.  
- AnalysisAgent updates a global anomaly map.  
- DecisionAgent synchronizes all information and dispatches ActionAgents.

### Communication Example
1. **DetectionAgent** → sends *inform(anomaly)* → **AnalysisAgent**.  
2. **AnalysisAgent** → sends *inform(validation)* → **DecisionAgent**.  
3. **DecisionAgent** → sends *request(action)* → **ActionAgent**.  
4. **ActionAgent** → executes and reports status back.

---

## ⚙️ Agent Architectures

| Agent | Architecture | Components |
|--------|--------------|-------------|
| **DetectionAgent** | Reactive | Perception → Action |
| **AnalysisAgent** | Deliberative | Beliefs (symptom data), Desires (accuracy), Intentions (classification) |
| **DecisionAgent** | Hybrid | Combines reasoning (BDI) with reactive task assignment |
| **ActionAgent** | Reactive | Sensor input → Physical actuation |

---

## 🏗️ Work Plan – Week 1

| Task | Responsible | Date | Effort | Status |
|------|--------------|------|---------|--------|
| Define context and crop anomalies | All | Week 1 | 3h | ✅ Completed |
| Design greenhouse grid and path model | Juan Pablo | Week 1 | 4h | 🔄 In progress |
| Define agents and interaction protocol | Esteban & Fernanda | Week 1 | 3h | ✅ Completed |
| Implement simulation skeleton | Joaquin | Week 2 | 5h | ⏳ Pending |
| Prepare Review 1 document | Joaquin | Week 1 | 3h | ✅ Completed |
| Tag repository as REVISION 1 | All | Week 1 | 1h | ⏳ Pending |

---

## 🧠 Acquired Learning
- Learned to represent agricultural systems within a **digital greenhouse**.  
- Differentiated **Reactive**, **Deliberative**, and **Hybrid** agent behaviors.  
- Applied **graph theory** to model efficient greenhouse navigation and coverage.  
- Improved team coordination using **GitHub** and structured communication protocols.

---

## 🏷️ Tagging and Submission

The repository’s last commit for this activity will be tagged as:

REVISION 1 


### Submission Instructions
1. Upload the report and diagrams to `/reports` and `/diagrams`.  
2. Verify consistency between README and the formal document.  
3. Submit the repository link through the course platform with tag `REVISION 1`.

---

## 📎 Credits
**Course:** Multi-Agent Systems – Review 1 (Week 1, 6%)  
**Team:** Detection and Management of Vegetation with Anomalies (Traffic Jam)  
**Crop:** Tomato (Jitomate)  
**Institution:** Tecnológico de Monterrey  
**Date:** November 2025  

---

© 2025 – MAS Agricultural Systems Team. All rights reserved.
