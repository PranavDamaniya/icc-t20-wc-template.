document.getElementById('save-btn').addEventListener('click', () => {
    const rows = document.querySelectorAll('#wc-table tbody tr');
    const data = Array.from(rows).map(row => {
        const cells = row.querySelectorAll('td');
        return {
            stage: cells[0].innerText,
            team1: cells[1].innerText,
            team2: cells[2].innerText
        };
    });

    console.log('Saved Data:', data);
    alert('Teams saved successfully!');
});
