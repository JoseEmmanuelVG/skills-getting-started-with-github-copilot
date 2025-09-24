const express = require('express');
const app = express();
const port = 3001;

app.use(express.json());

// POST /generate endpoint
app.post('/generate', (req, res) => {
  const { text } = req.body;
  // Example: echo the text back with a message
  res.json({ result: `You sent: ${text}` });
});

app.listen(port, () => {
  console.log(`API server listening at http://localhost:${port}`);
});
