const input = document.getElementById("data-input");
const button = document.getElementById("update-button");
const chart = d3.select("#chart");

function updateChart(data) {

  chart.selectAll("*").remove();

  const width = 500;
  
  const barHeight = 20;


  const svg = chart
    .append("svg")
    .attr("width", width)
    .attr("height", data.length * barHeight);


  const color = d3.scaleOrdinal(d3.schemeCategory10);

  svg
    .selectAll("rect")
    .data(data)
    .enter()
    .append("rect")
    .attr("x", 0)
    .attr("y", (d, i) => i * barHeight)
    .attr("width", d => d * 10) 
    .attr("height", barHeight - 2)
    .attr("fill", (d, i) => color(i));

  
  svg
    .selectAll("text")
    .data(data)
    .enter()
    .append("text")
    .attr("x", d => d * 10 + 5)
    .attr("y", (d, i) => i * barHeight + barHeight / 2)
    .attr("dy", ".35em")
    .text(d => d);
}

button.addEventListener("click", () => {
  const rawData = input.value;
  const data = rawData
    .split(",")
    .map(Number)
    .filter(num => !isNaN(num)); 

  if (data.length) {
    updateChart(data);
  } else {
    alert("Por favor, ingresa números válidos separados por comas.");
  }
});
