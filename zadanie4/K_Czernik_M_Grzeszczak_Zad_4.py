
import pyaudio
import wave
import time
import tkinter as tk

class AudioRecorderPlayer:
    def __init__(self, master):
        self.master = master
        master.title("Przetwarzanie analogowo-cyfrowe A/C")

        # Ustawienia audio
        self.format = pyaudio.paInt16
        self.channels = 1
        self.sample_rate = tk.IntVar(value=16000)
        self.chunk_size = tk.IntVar(value=1024)
        self.record_seconds = 5
        self.file_name = "recorded_audio.wav"

        # Inicjalizacja obiektu PyAudio
        self.audio = pyaudio.PyAudio()

        # Elementy GUI
        self.sample_rate_label = tk.Label(master, text="częstotliwości próbkowania:")
        self.sample_rate_entry = tk.Entry(master, textvariable=self.sample_rate)
        self.chunk_size_label = tk.Label(master, text="ilości próbek dźwięku:")
        self.chunk_size_entry = tk.Entry(master, textvariable=self.chunk_size)
        self.record_button = tk.Button(master, text="Nagraj", command=self.record)
        self.play_button = tk.Button(master, text="Odtwórz", command=self.play)

        # Układ GUI
        self.sample_rate_label.grid(row=0, column=0, padx=5, pady=5)
        self.sample_rate_entry.grid(row=0, column=1, padx=5, pady=5)
        self.chunk_size_label.grid(row=1, column=0, padx=5, pady=5)
        self.chunk_size_entry.grid(row=1, column=1, padx=5, pady=5)
        self.record_button.grid(row=2, column=0, padx=5, pady=5)
        self.play_button.grid(row=2, column=1, padx=5, pady=5)

    def record(self):
        # Otwarcie strumienia audio z mikrofonu
        stream = self.audio.open(format=self.format,
                                 channels=self.channels,
                                 rate=self.sample_rate.get(),
                                 input=True,
                                 frames_per_buffer=self.chunk_size.get())

        print("Recording audio...")

        # Lista do przechowywania ramek audio
        frames = []

        # Nagrywanie audio
        for i in range(0, int(self.sample_rate.get() / self.chunk_size.get() * self.record_seconds)):
            data = stream.read(self.chunk_size.get())
            frames.append(data)

        print("Finished recording audio.")

        # Zatrzymanie i zamknięcie strumienia audio
        stream.stop_stream()
        stream.close()

        # Zapisanie ramek audio do pliku WAV
        wf = wave.open(self.file_name, 'wb')
        wf.setnchannels(self.channels)
        wf.setsampwidth(self.audio.get_sample_size(self.format))
        wf.setframerate(self.sample_rate.get())
        wf.writeframes(b''.join(frames))
        wf.close()

        # Wyświetlenie wyników
        print("#Results")
        print("Sampling rate: ", self.sample_rate.get(), "Hz")
        print("Chunk size: ", self.chunk_size.get())
        print("Recorded audio saved as: ", self.file_name)

    def play(self):
        # Otwarcie pliku WAV
        wf = wave.open(self.file_name, 'rb')

        # Inicjalizacja strumienia audio
        stream = self.audio.open(format=self.audio.get_format_from_width(wf.getsampwidth()),
                                 channels=wf.getnchannels(),
                                 rate=wf.getframerate(),
                                 output=True)

        print("Playing audio...")

        # Odtwarzanie ramek audio w strumieniu audio
        data = wf.readframes(self.chunk_size.get())
        while data:
            stream.write(data)
            data = wf.readframes(self.chunk_size.get())

        # Zatrzymanie odtwarzania
        stream.stop_stream()
        stream.close()

        # Zamknięcie pliku .wav
        wf.close()


if __name__ == '__main__':
    root = tk.Tk()
    app = AudioRecorderPlayer(root)
    root.mainloop()
