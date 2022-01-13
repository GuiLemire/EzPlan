export class Tache {
    tacheID?: number;
    nom?: string;
    dureeApproximative?: number;
    dureeMaxConsecutive?: number;
    niveauDeStress?: number;

    constructor () {
        this.nom = "", 
        this.dureeApproximative = 15, 
        this.dureeMaxConsecutive = 15, 
        this.niveauDeStress = 0
    }
}