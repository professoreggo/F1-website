function fetchRaceSchedule() {
    fetch('https://ergast.com/api/f1/current.json')
        .then(response => response.json())
        .then(data => {
            const races = data.MRData.RaceTable.Races;
            const raceTable = document.getElementById('raceTable');

            races.forEach(race => {
                const row = document.createElement('tr');

                const raceNameCell = document.createElement('td');
                raceNameCell.textContent = race.raceName;
                row.appendChild(raceNameCell);

                const circuitNameCell = document.createElement('td');
                circuitNameCell.textContent = race.Circuit.circuitName;
                row.appendChild(circuitNameCell);

                const dateCell = document.createElement('td');
                dateCell.textContent = race.date;
                row.appendChild(dateCell);

                // Fetch the winner of the race
                fetch(`https://ergast.com/api/f1/2024/${race.round}/results/1.json`)
                    .then(response => response.json())
                    .then(data => {
                        let winner = "Upcoming";
                        if (data.MRData.RaceTable.Races.length > 0) {
                            winner = data.MRData.RaceTable.Races[0].Results[0].Driver.givenName + ' ' + data.MRData.RaceTable.Races[0].Results[0].Driver.familyName;
                        }

                        // Add a new cell for the winner
                        const winnerCell = document.createElement('td');
                        winnerCell.textContent = winner;
                        row.appendChild(winnerCell);
                    })
                    .catch(error => {
                        console.error('Error fetching race winner:', error);
                    });

                raceTable.appendChild(row);
            });
        })
        .catch(error => {
            console.error('Error fetching race schedule:', error);
        });
}

// Call the fetchRaceSchedule function when the page loads
window.onload = fetchRaceSchedule;
