### 远程实验管理系统 | Remote Experiment Management System

A comprehensive platform designed for remote FPGA development and real-time experiment monitoring, seamlessly integrating with ESP32 cameras and Alibaba Cloud OSS for secure data storage. This system empowers educators, researchers, and students to conduct hardware experiments remotely while maintaining full control over FPGA configurations and live visual feedback.
### 🌟 **Key Features**
- **FPGA Remote Control**: Upload bitstreams and manage FPGA configurations via web interface.
- **ESP32 Camera Integration**: Real-time video streaming of physical experiment setups.
- **Alibaba Cloud OSS Storage**: Securely store user credentials, experiment data, and captured media.
- **Multi-user Management**: Role-based access control for instructors and students.
- **Experiment Logging**: Track experiment history and generate detailed reports.
- **Responsive Design**: Accessible from any device with a modern web browser.

### 🚀 **Technical Stack**
- **Backend**: Python (Flask), integrating with Alibaba Cloud OSS API
- **Frontend**: Winform
- **Database**: SQLite (development), scalable to PostgreSQL
- **Real-time Communication**: WebSocket for live camera streaming
- **Deployment**: Dockerized for easy setup and scalability

### 📦 **Installation**
1. Clone the repository:
   ```bash
   git clone https://github.com/StanHuanng/remote-experiment-system.git
   cd remote-experiment-system
   ```
2. Install dependencies:
   ```bash
   pip install -r requirements.txt
   ```
3. Configure environment variables:
   ```bash
   cp .env.example .env
   # Edit .env with your Alibaba Cloud OSS credentials and FPGA settings
   ```


### 🤝 **Contributing**
We welcome contributions from the community! Please read our [contributing guidelines](CONTRIBUTING.md) before submitting pull requests.

### 📄 **License**
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

### 📧 **Contact**
For any questions or support, please open an issue on GitHub or contact us at [huangluming08@foxmail.com](mailto:email@example.com).

Let's build the future of remote hardware education together! 🚀

---
