# **Secure Document Archive with AI-Powered Search & IDS**  

🔐 **A secure document management system integrating AI-based intrusion detection and RAG-enhanced search.**  

## 📌 **Overview**  
This project is a **secure document archive** that ensures encrypted storage, AI-driven anomaly detection, and intelligent document retrieval. It leverages **ASP.NET Core, Vue.js, PostgreSQL, Weaviate (vector database), and PyTorch** to create a robust, scalable, and secure system.  

## ✨ **Features**  
✅ **Role-Based Access Control (RBAC)** – Restricts access based on user roles.  
✅ **AES-256 Encryption** – Ensures secure document storage.  
✅ **AI-Powered Intrusion Detection (IDS)** – Detects unauthorized access attempts using a PyTorch model.  
✅ **RAG-Based Search** – Uses a vector database for intelligent document retrieval.  
✅ **JWT Authentication** – Secure login and API access.  
✅ **File Upload & Management** – Store and retrieve documents efficiently.  

## 🏗 **Tech Stack**  
- **Frontend:** Vue.js 3  
- **Backend:** ASP.NET Core  
- **Database:** PostgreSQL (metadata) + Weaviate (vector search)  
- **Machine Learning:** PyTorch (for IDS)  
- **Security:** AES-256 encryption, JWT authentication  


## 📖 **How It Works**  
1. **Users upload encrypted documents** via the frontend.  
2. **Metadata is stored in PostgreSQL,** while **vector embeddings are indexed in Weaviate**.  
3. **A PyTorch-based IDS model monitors login anomalies** and raises alerts for suspicious activity.  
4. **Users can search documents** using keyword-based search or **RAG-enhanced vector search**.  

## 🛡 **Security Measures**  
- **AES-256 Encryption** – Ensures secure file storage.  
- **Role-Based Access Control** – Limits document access based on user roles.  
- **Intrusion Detection System (IDS)** – AI model detects suspicious login behavior.  
- **Logging & Monitoring** – Tracks user activity for audit purposes.  

## 🎯 **Roadmap**  
✅ Core authentication & role-based access  
✅ Document upload with AES encryption  
✅ IDS integration with real-time alerts  
✅ RAG-based search with vector embeddings  
⏳ Performance optimization & scalability improvements  

## 🤝 **Contributing**  
We welcome contributions! Open an issue or submit a pull request to help improve the project.  

## 📜 **License**  
This project is licensed under the **MIT License**.  
