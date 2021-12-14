export class Tache {
    id?: number;
    nom?: string;
    dureeApproximative?: number;
    dureeMaxConsecutive?: number;
    niveauDeStress?: number;

    constructor(tache: any) {
        this.id = tache.id;
        this.nom = tache.nom;
        this.dureeApproximative = tache.dureeApproximative;
        this.dureeMaxConsecutive = tache.dureeMaxConsecutive;
        this.niveauDeStress = tache.niveauDeStress;
    }
}