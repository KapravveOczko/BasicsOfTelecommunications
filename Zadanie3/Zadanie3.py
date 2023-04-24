import tkinter as tk
import socket
import threading
import subprocess

# Funkcja obsługująca komunikację z klientem
def handle_client(client_socket, client_address):
    while True:
        data = client_socket.recv(1024).decode('utf-8')
        if not data:
            break
        print(f"Klient {client_address}: {data}")
        client_socket.send(f"Odpowiedź serwera: {data}".encode('utf-8'))
    client_socket.close()

# Funkcja obsługująca nasłuchiwanie na połączenia
def start_server():
    server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    ip = socket.gethostbyname(socket.gethostname()).split()[0]
    server_socket.bind(("192.168.222.109", 8888))
    server_socket.listen(5)
    print("Serwer na adress: ", ip)
    print("Serwer nasłuchuje na porcie 8888...")

    while True:
        client_socket, client_address = server_socket.accept()
        print(f"Połączenie od: {client_address}")
        client_thread = threading.Thread(target=handle_client, args=(client_socket, client_address))
        client_thread.start()

# Funkcja obsługująca połączenie jako klient
def connect_to_server():
    server_address = entry_server.get()
    server_port = int(entry_port.get())

    client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    client_socket.connect((server_address, server_port))
    print("Połączono z serwerem")

    while True:
        message = entry_message.get()
        if not message:
            break
        client_socket.send(message.encode('utf-8'))
        data = client_socket.recv(1024).decode('utf-8')
        print(f"Odpowiedź serwera: {data}")
        entry_message.delete(0, tk.END)

    client_socket.close()

# Tworzenie okna programu
root = tk.Tk()
root.title("Serwer i klient")

# Etykiety
label_server = tk.Label(root, text="Adres serwera:")
label_server.grid(row=0, column=0, padx=5, pady=5)
label_port = tk.Label(root, text="Port serwera:")
label_port.grid(row=1, column=0, padx=5, pady=5)
label_message = tk.Label(root, text="Wiadomość:")
label_message.grid(row=2, column=0, padx=5, pady=5)

# Pola tekstowe
entry_server = tk.Entry(root)
entry_server.grid(row=0, column=1, padx=5, pady=5)
entry_port = tk.Entry(root)
entry_port.grid(row=1, column=1, padx=5, pady=5)
entry_message = tk.Entry(root)
entry_message.grid(row=2, column=1, padx=5, pady=5)

# Przyciski
button_start_server = tk.Button(root, text="Uruchom serwer", command=start_server)
button_start_server.grid(row=3, column=0, padx=5, pady=5)
button_connect_to_server = tk.Button(root, text="Połącz z serwerem", command=connect_to_server)
button_connect_to_server.grid(row=3, column=1, padx=5, pady=5)


root.mainloop()