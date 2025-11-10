# 🧠 Load Movement Request – Multi-Agent System Challenge

## 📘 Project Overview
This project implements a **Multi-Agent System (MAS)** designed to coordinate the movement of boxes in a warehouse between three key roles:  
an **Operator**, a **Forklift (Carrier)**, and an **Inventory Manager**.  

The system models **autonomous decision-making and communication** among agents to ensure that every load transfer request is **valid, efficient, and consistent** with inventory policies.  
It demonstrates **agent autonomy**, **coordination**, and **interaction protocols (AIP)** in a realistic warehouse scenario.

---

## 👥 Team Members

| Name | Role | Strengths | Areas of Opportunity |
|------|------|------------|----------------------|
| Joaquin Hiroki | Project Leader / MAS Architect | Organization, leadership, and system modeling | Needs to delegate more frequently |
| Juan Pablo Buenrostro | Software Developer | Strong coding and debugging skills | Improve documentation habits |
| Fernanda Jimenez | Research & Documentation | Clear writing, analytical thinking | Gain confidence in technical tools |
| Esteban Munoz | QA / Tester | Attention to detail, structured validation | Improve time management |

### Team Expectations
- Understand and apply **agent-based modeling** concepts effectively.  
- Deliver a **functional prototype** demonstrating communication between autonomous agents.  
- Maintain **consistent documentation** and **team accountability** through GitHub.

### Commitments
- Weekly coordination meetings.  
- Continuous updates through GitHub commits.  
- Clear communication in the shared channel.  
- Support and feedback among all team members.

---

## 💬 Collaborative Tools

| Tool | Purpose | Description |
|------|----------|-------------|
| **GitHub** | Version control | Repository where all code, documentation, and diagrams are stored. |
| **Discord / WhatsApp** | Communication | Used for real-time collaboration and meeting coordination. |
| **Overleaf / Word** | Documentation | To create and maintain formal reports with visual consistency. |

**Repository name:** `MAS_LoadMovement_Team`  

**Structure:**
/docs → Documentation and references
/src → Source code (agents, protocols)
/diagrams → UML and AIP diagrams
/reports → Formal review documents (Review 1, 2, etc.)                                                                                                    
---

## 🧩 Agents Description

| Agent | Type of Architecture | Description | Role in the System |
|--------|----------------------|--------------|--------------------|
| **OperatorAgent** | Reactive | Perceives and sends direct requests to move boxes. | Initiates “Load Movement Request”. |
| **ForkliftAgent** | **Hybrid** | Integrates deliberative reasoning with reactive actions. | Executes movements after validating rules with the Inventory Manager. |
| **InventoryAgent** | Deliberative | Contains inventory beliefs, evaluates rules and availability. | Approves or rejects movement requests. |

### 🔁 Interaction Flow (AIP Overview)
1. **OperatorAgent** → *request* → **ForkliftAgent**: asks to move `box_123` from `loc_A` to `loc_B`.  
2. **ForkliftAgent** → *query* → **InventoryAgent**: verifies if the movement is valid.  
3. **InventoryAgent** → *inform* → **ForkliftAgent**: approves or rejects the request.  
4. **ForkliftAgent** → *inform* → **OperatorAgent**: communicates the final outcome (success or refusal).

---

## ⚙️ Agent Architectures

### 🟩 OperatorAgent (Reactive)
- **Perception Layer:** Detects movement requests.  
- **Action Layer:** Sends load transfer commands to the Carrier.  

### 🟦 InventoryAgent (Deliberative)
- **Beliefs:** Stores warehouse data and item locations.  
- **Desires:** Maintain inventory consistency.  
- **Intentions:** Validate and authorize only logical transfers.  

### 🟨 ForkliftAgent (Hybrid)
- **Beliefs:** Knows box positions and route map.  
- **Desires:** Complete assigned tasks safely.  
- **Intentions:** Plan and execute movements.  
- **Reactive Layer:** Responds to Operator or Manager messages immediately.  

---

## 🏗️ Work Plan – Week 1

| Task | Responsible | Date | Estimated Effort | Status |
|------|--------------|------|------------------|--------|
| Define project challenge and scope | All | Week 1 | 4h | ✅ Completed |
| Identify and describe agents | Esteban & [Name 3] | Week 1 | 3h | ✅ Completed |
| Create GitHub repo and communication group | [Name 2] | Week 1 | 2h | ✅ Completed |
| Draft agent interaction diagram (AIP) | [Name 4] | Week 2 | 4h | 🔄 In Progress |
| Prepare formal Review 1 document | [Name 3] | Week 1 | 3h | ✅ Completed |
| Tag and submit repository as REVISION 1 | All | Week 1 | 1h | ⏳ Pending |

---

## 🧠 Acquired Learning

- Recognized differences between **Reactive**, **Deliberative**, and **Hybrid** agent architectures.  
- Learned to structure a **Multi-Agent System** based on **autonomy and communication**.  
- Applied teamwork principles with **version control tools** (GitHub) and coordination channels (Discord).  
- Developed understanding of **interaction protocols** and **message exchange** in agent systems.

---

## 🏷️ Tagging and Submission

The repository’s last commit for this activity will be tagged as:


### Submission Instructions
1. Ensure all documentation (PDF and diagrams) is uploaded to `/reports` and `/diagrams`.  
2. Verify consistency between README and the formal document.  
3. Submit the GitHub repository **link** with the `REVISION 1` tag via the official course platform.

---

## 📎 Credits
**Course:** Multi-Agent Systems – Review 1 (Week 1, 6%)  
**Team:** MAS Load Movement Challenge  
**Institution:** Tecnológico de Monterrey  
**Date:** November 2025  

---

© 2025 – MAS Team. All rights reserved.
