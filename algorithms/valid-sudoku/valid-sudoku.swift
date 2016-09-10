class Solution {
    func isValidSudoku(board: [[Character]]) -> Bool {
        if !checkEverySquare(board) || !checkEveryColumn(board) || !checkEveryRow(board) {
            return false
        }
        return true
    }
    
    func checkEverySquare(board: [[Character]]) -> Bool {
        for i in 0..<3 {
            for j in 0..<3 {
                if !checkSquare(board, row: i * 3, col: j * 3) {
                    return false
                }
            }
        }
        return true
    }
    
    func checkSquare(board: [[Character]], row: Int, col: Int) -> Bool{
        for i in 0..<9 {
            for j in 0..<9 {
                guard i != j else {
                    continue
                }
                let element1 = getElement(board, row: row, col: col, num: i)
                let element2 = getElement(board, row: row, col: col, num: j)
                guard String(element2) != "." else {
                    continue
                }
                guard String(element1) != "." else {
                    break
                }
                if element1 == element2 {
                    return false
                }
            }
        }
        return true
    }
    
    func getElement(board: [[Character]], row: Int, col: Int, num: Int) -> Character {
        let rowOffset = num / 3
        let colOffset = num % 3
        return board[row + rowOffset][col + colOffset]
    }
    
    func checkEveryColumn(board: [[Character]]) -> Bool {
        for i in 0..<9 {
            if !checkColumn(board, col: i) {
                return false
            }
        }
        return true
    } 
    
    func checkColumn(board: [[Character]], col: Int) -> Bool {
        for i in 0..<9 {
            for j in i..<9 {
                guard i != j else {
                    continue
                }
                guard String(board[j][col]) != "." else {
                    continue
                }
                guard String(board[i][col]) != "." else {
                    break
                }
                if board[i][col] == board[j][col] {
                    return false
                }
            }
        }
        return true
    }
    
    func checkEveryRow(board: [[Character]]) -> Bool {
        for i in 0..<9 {
            if !checkRow(board, row: i) {
                return false
            }
        }
        return true
    } 
    
    func checkRow(board: [[Character]], row: Int) -> Bool {
        for i in 0..<9 {
            for j in i..<9 {
                guard i != j else {
                    continue
                }
                guard String(board[row][j]) != "." else {
                    continue
                }
                guard String(board[row][i]) != "." else {
                    break
                }
                if board[row][i] == board[row][j] {
                    return false
                }
            }
        }
        return true
    }
}