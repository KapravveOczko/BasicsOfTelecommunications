
import pyaudio
import wave
import time
import tkinter as tk

class AudioRecorderPlayer:
    def __init__(self, master):
        self.master = master
        master.title("Audio Recorder and Player")

        # Audio settings
        self.format = pyaudio.paInt16
        self.channels = 1
        self.sample_rate = tk.IntVar(value=16000)
        self.chunk_size = tk.IntVar(value=1024)
        self.record_seconds = 5
        self.file_name = "recorded_audio.wav"

        # PyAudio object initialization
        self.audio = pyaudio.PyAudio()

        # GUI elements
        self.sample_rate_label = tk.Label(master, text="Sampling Rate:")
        self.sample_rate_entry = tk.Entry(master, textvariable=self.sample_rate)
        self.chunk_size_label = tk.Label(master, text="Chunk Size:")
        self.chunk_size_entry = tk.Entry(master, textvariable=self.chunk_size)
        self.record_button = tk.Button(master, text="Record", command=self.record)
        self.play_button = tk.Button(master, text="Play", command=self.play)

        # GUI layout
        self.sample_rate_label.grid(row=0, column=0, padx=5, pady=5)
        self.sample_rate_entry.grid(row=0, column=1, padx=5, pady=5)
        self.chunk_size_label.grid(row=1, column=0, padx=5, pady=5)
        self.chunk_size_entry.grid(row=1, column=1, padx=5, pady=5)
        self.record_button.grid(row=2, column=0, padx=5, pady=5)
        self.play_button.grid(row=2, column=1, padx=5, pady=5)

    def record(self):
        # Open audio stream from microphone
        stream = self.audio.open(format=self.format,
                                 channels=self.channels,
                                 rate=self.sample_rate.get(),
                                 input=True,
                                 frames_per_buffer=self.chunk_size.get())

        print("Recording audio...")

        # List to store audio frames
        frames = []

        # Record audio
        for i in range(0, int(self.sample_rate.get() / self.chunk_size.get() * self.record_seconds)):
            data = stream.read(self.chunk_size.get())
            frames.append(data)

        print("Finished recording audio.")

        # Stop and close audio stream
        stream.stop_stream()
        stream.close()

        # Save audio frames to WAV file
        wf = wave.open(self.file_name, 'wb')
        wf.setnchannels(self.channels)
        wf.setsampwidth(self.audio.get_sample_size(self.format))
        wf.setframerate(self.sample_rate.get())
        wf.writeframes(b''.join(frames))
        wf.close()

        # Display results
        print("#Results")
        print("Sampling rate: ", self.sample_rate.get(), "Hz")
        print("Chunk size: ", self.chunk_size.get())
        print("Recorded audio saved as: ", self.file_name)

    def play(self):
        # Open WAV file
        wf = wave.open(self.file_name, 'rb')

        # Initialize audio stream
        stream = self.audio.open(format=self.audio.get_format_from_width(wf.getsampwidth()),
                                 channels=wf.getnchannels(),
                                 rate=wf.getframerate(),
                                 output=True)

        print("Playing audio...")

        # Play audio frames in audio stream
        data = wf.readframes(self.chunk_size.get())
        while data:
            stream.write(data)
            data = wf.readframes(self.chunk_size.get())

        # Stop playback
        stream.stop_stream()
        stream.close()

        # Close .wav file
        wf.close()


if __name__ == '__main__':
    root = tk.Tk()
    app = AudioRecorderPlayer(root)
    root.mainloop()
