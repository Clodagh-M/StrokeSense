let mediaRecorder = null;
let audioChunks = [];
let lastBlobUrl = null;

export async function startRecording() {
    try {
        const stream = await navigator.mediaDevices.getUserMedia({ audio: true });
        mediaRecorder = new MediaRecorder(stream);
        audioChunks = [];

        mediaRecorder.ondataavailable = (event) => {
            if (event.data.size > 0) {
                audioChunks.push(event.data);
            }
        };

        mediaRecorder.start();
        return true;
    } catch (err) {
        console.error("Microphone error:", err);
        return false;
    }
}

export function stopRecording() {
    if (mediaRecorder && mediaRecorder.state !== "inactive") {
        mediaRecorder.stop();
        mediaRecorder.stream.getTracks().forEach(t => t.stop());
    }
}

export function playbackLastRecording() {
    if (audioChunks.length === 0) return;

    const blob = new Blob(audioChunks, { type: "audio/webm" });
    if (lastBlobUrl) {
        URL.revokeObjectURL(lastBlobUrl);
    }
    lastBlobUrl = URL.createObjectURL(blob);

    const audio = new Audio(lastBlobUrl);
    audio.play();
}